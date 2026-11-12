using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BowlingBal : MonoBehaviour
{
    private Rigidbody rb;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable interactable;

    void Awake()// pakt de rigidbody en interactable
    {
        rb = GetComponent<Rigidbody>();
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>();
    }

    void OnEnable()// voegt een listener toe aan de interactable
    {
        if (interactable != null)
        {
            GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>().selectExited.AddListener(OnBallReleased);
        }
    }

    void OnDisable()// haalt een listerner van de interactable af
    {
        if (interactable != null)
        {
            GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>().selectExited.RemoveListener(OnBallReleased);
        }
    }

    public void OnBallReleased(SelectExitEventArgs args)// gebeurd wanneer de bal word losgelaten
    {
        Invoke(nameof(FlattenTrajectory), 0.1f);
    }

    private void FlattenTrajectory()// zorgt ervoor dat alleen de hoogte van de gegooide bal maar 10% zo hoog kan als dat hij normaal kan
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
