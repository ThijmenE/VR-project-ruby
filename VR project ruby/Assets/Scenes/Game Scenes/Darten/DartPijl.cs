using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class DartPijl : MonoBehaviour
{
    private Rigidbody rb;
    private XRGrabInteractable grabInteractable;
    private FixedJoint boardJoint;
    private Rigidbody boardBody;
    private Collider boardCollider;
    private bool isGrabbed;
    private bool touchingBoard;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<XRGrabInteractable>();
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

        ReleaseFromBoard();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("DartBoard"))
            return;

        touchingBoard = true;
        boardCollider = collision.collider;
        boardBody = GetOrCreateBoardBody(boardCollider);

        if (!isGrabbed)
            AttachToBoard(collision.contactCount > 0 ? collision.contacts[0].point : collision.collider.ClosestPoint(transform.position));
    }

    private void OnCollisionExit(Collision collision)
    {
        if (!collision.gameObject.CompareTag("DartBoard"))
            return;

        touchingBoard = false;
        boardCollider = null;
        boardBody = null;
        ReleaseFromBoard();
    }

    private void OnDartGrabbed(SelectEnterEventArgs args)
    {
        isGrabbed = true;
        ReleaseFromBoard();
    }

    private void OnDartReleased(SelectExitEventArgs args)
    {
        isGrabbed = false;

        if (touchingBoard && boardCollider != null)
        {
            AttachToBoard(boardCollider.ClosestPoint(transform.position));
        }
    }

    private void AttachToBoard(Vector3 contactPoint)
    {
        if (boardBody == null || boardJoint != null)
            return;

        boardJoint = gameObject.AddComponent<FixedJoint>();
        boardJoint.connectedBody = boardBody;
        boardJoint.autoConfigureConnectedAnchor = false;
        boardJoint.anchor = rb.transform.InverseTransformPoint(contactPoint);
        boardJoint.connectedAnchor = boardBody.transform.InverseTransformPoint(contactPoint);
        boardJoint.enableCollision = false;
        boardJoint.breakForce = Mathf.Infinity;
        boardJoint.breakTorque = Mathf.Infinity;
    }

    private void ReleaseFromBoard()
    {
        if (boardJoint != null)
        {
            Destroy(boardJoint);
            boardJoint = null;
        }
    }

    private static Rigidbody GetOrCreateBoardBody(Collider boardCollider)
    {
        Rigidbody body = boardCollider.attachedRigidbody;
        if (body == null)
            body = boardCollider.GetComponentInParent<Rigidbody>();

        if (body == null)
        {
            body = boardCollider.gameObject.AddComponent<Rigidbody>();
            body.isKinematic = true;
            body.useGravity = false;
        }

        return body;
    }
}