using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SocketTagCheck : XRSocketInteractor
{
    public string targetTag = string.Empty;

    public override bool CanHover(IXRHoverInteractable interactable)
    {
        return base.CanHover(interactable)
            && interactable is XRBaseInteractable baseInteractable
            && MatchUsingTag(baseInteractable);
    }

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable)
            && interactable is XRBaseInteractable baseInteractable
            && MatchUsingTag(baseInteractable);;
    }

    private bool MatchUsingTag(XRBaseInteractable interactable) //Checks for the tag of the object inside the socket
    {
        return interactable.CompareTag(targetTag);
    }
}