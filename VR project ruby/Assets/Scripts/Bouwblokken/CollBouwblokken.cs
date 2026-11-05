using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using System.Collections;

public class CollBouwblokken : MonoBehaviour
{
    private Rigidbody rb;

    private XRGrabInteractable grabInteractable;
    private Rigidbody boxBody;
    private Collider boxCollider;
    private bool touching;
    private Coroutine freezeCoroutine;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnGrabbed);
            grabInteractable.selectExited.AddListener(OnReleased);
        }
    }

    private void OnDisable()
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.RemoveListener(OnGrabbed);
            grabInteractable.selectExited.RemoveListener(OnReleased);
        }

        if (freezeCoroutine != null)
        {
            StopCoroutine(freezeCoroutine);
            freezeCoroutine = null;
        }
    }

    private void OnGrabbed(SelectEnterEventArgs args)
    {
        CancelFreeze();
        rb.isKinematic = false;
    }

    private void OnReleased(SelectExitEventArgs args)
    {
        rb.isKinematic = false;

        if (grabInteractable.isSelected)
            return;

        CancelFreeze();
        freezeCoroutine = StartCoroutine(FreezeAfterRelease());
    }

    private IEnumerator FreezeAfterRelease()
    {
        yield return new WaitForSeconds(1f);

        Vector3 previousPosition = transform.position;
        Quaternion previousRotation = transform.rotation;

        while (!grabInteractable.isSelected)
        {
            yield return new WaitForSeconds(0.1f);

            Vector3 currentPosition = transform.position;
            Quaternion currentRotation = transform.rotation;
            bool positionIsStable = Vector3.Distance(previousPosition, currentPosition) < 0.01f;
            bool rotationIsStable = Quaternion.Angle(previousRotation, currentRotation) < 1f;

            if (positionIsStable && rotationIsStable && !grabInteractable.isSelected)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                rb.isKinematic = true;
                break;
            }

            previousPosition = currentPosition;
            previousRotation = currentRotation;
        }

        freezeCoroutine = null;
    }

    private void CancelFreeze()
    {
        if (freezeCoroutine == null)
            return;

        StopCoroutine(freezeCoroutine);
        freezeCoroutine = null;
    }

    private static Rigidbody GetOrCreateboxBody(Collider boxCollider)
    {
        Rigidbody body = boxCollider.attachedRigidbody;
        if (body == null)
            body = boxCollider.GetComponentInParent<Rigidbody>();

        if (body == null)
        {
            body = boxCollider.gameObject.AddComponent<Rigidbody>();
            body.isKinematic = true;
        }

        return body;
    }
}