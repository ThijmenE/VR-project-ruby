using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using System.Collections;

public class CollBouwblokken : MonoBehaviour
{
    private Rigidbody rb;

    private Rigidbody boxRb;
    private XRGrabInteractable grabInteractable;
    private FixedJoint Joint;
    private Rigidbody boxBody;
    private Collider boxCollider;
    private bool isGrabbed;
    private bool touching;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<XRGrabInteractable>();
        StartCoroutine(FreezeTimer());
    }

    private void OnEnable()
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnDartGrabbed);
            grabInteractable.selectExited.AddListener(OnDartReleased);
        }
    }

    private void OnDisable()
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.RemoveListener(OnDartGrabbed);
            grabInteractable.selectExited.RemoveListener(OnDartReleased);
        }

        Release();
    }

    private float lastVelocity;

    private IEnumerator FreezeTimer()
    {
        while (true)
        {
            lastVelocity = rb.linearVelocity.magnitude;
            yield return new WaitForSeconds(2f);
            if (Mathf.Abs(rb.linearVelocity.magnitude - lastVelocity) < 0.01f)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                rb.isKinematic = true;
                break;
            }

        }
            yield return null;
    }

    private void OnCollisionExit(Collision collision)
    {
        
        Debug.Log("Collision exit");
        if (collision.gameObject != null)
            return;

        touching = false;
        boxCollider = null;
        boxBody = null;
        Release();
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