using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class DartPijl : MonoBehaviour
{
    private static int dartsInBoard = 0;
    private Rigidbody rb;
    private XRGrabInteractable grabInteractable;
    private FixedJoint boardJoint;
    private Rigidbody boardBody;
    private Collider boardCollider;
    private bool isGrabbed;
    private bool touchingBoard;
    private bool isCountedInBoard;

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
        RemoveDartFromBoard();
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
        RemoveDartFromBoard();
        ReleaseFromBoard();
    }

    private void OnDartGrabbed(SelectEnterEventArgs args)
    {
        isGrabbed = true;
        RemoveDartFromBoard();
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

        if (!isCountedInBoard)
        {
            isCountedInBoard = true;
            dartsInBoard++;
            CheckDartScore();
        }
    }

    private void ReleaseFromBoard()
    {
        if (boardJoint != null)
        {
            Destroy(boardJoint);
            boardJoint = null;
        }
    }

    private void RemoveDartFromBoard()
    {
        if (!isCountedInBoard)
            return;

        isCountedInBoard = false;
        dartsInBoard = Mathf.Max(0, dartsInBoard - 1);
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

    private void CheckDartScore()
    {
        if (dartsInBoard == 3)
        {
            Robottext robotText = FindObjectOfType<Robottext>();
            if (robotText != null)
            {
                robotText.ScoreDarten();
            }
        }
    }
}