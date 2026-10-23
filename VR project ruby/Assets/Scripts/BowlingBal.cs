using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BowlingBal : MonoBehaviour
{
    private Rigidbody rb;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable interactable;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>();
    }

    void OnEnable()
    {
        if (interactable != null)
        {
            GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>().selectExited.AddListener(OnBallReleased);
        }
    }

    void OnDisable()
    {
        if (interactable != null)
        {
            GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>().selectExited.RemoveListener(OnBallReleased);
        }
    }

    public void OnBallReleased(SelectExitEventArgs args)
    {
        Invoke(nameof(FlattenTrajectory), 0.1f);
    }

    private void FlattenTrajectory()
    {
        Vector3 currentVelocity = rb.linearVelocity;

        float maxheight = 1.2f;

        if (currentVelocity.y > maxheight)
        {
            currentVelocity.y = maxheight;
        }
        else if (currentVelocity.y > 0)
        {
            currentVelocity.y *= 0.1f;
        }

        rb.linearVelocity = currentVelocity;
    }

}
