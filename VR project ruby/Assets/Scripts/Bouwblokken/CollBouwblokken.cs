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

    private void Awake()// pakt de components van de rigidbody en gradinteractable
    {
        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()// wanneer je een item pakt worden de listeners toegevoegd
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnGrabbed);
            grabInteractable.selectExited.AddListener(OnReleased);
        }
    }

    private void OnDisable()// wanneer je een item loslaat worden de listeners verwijdert
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

    private void OnGrabbed(SelectEnterEventArgs args)// wanneer je een item pakt word kinematic modus uitgezet
    {
        CancelFreeze();
        rb.isKinematic = false;
    }

    private void OnReleased(SelectExitEventArgs args)// wanneer een item word losgelaten gaat kinematic modus aan een seconde nadat het item ongeveer stil ligt
    {
        rb.isKinematic = false;

        if (grabInteractable.isSelected)
            return;

        CancelFreeze();
        freezeCoroutine = StartCoroutine(FreezeAfterRelease());
    }

    private IEnumerator FreezeAfterRelease()// een check voor wanneer de blokken minder dan 0.01 afstand verplaatst en minder dan een graad roteert om het object op kinematic te zetten
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

    private void CancelFreeze()// deze method stopt de freeze coroutine
    {
        if (freezeCoroutine == null)
            return;

        StopCoroutine(freezeCoroutine);
        freezeCoroutine = null;
    }

    private static Rigidbody GetOrCreateboxBody(Collider boxCollider)// als er geen rigidbody word gevonden word er een aangemaakt
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