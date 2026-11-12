using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SocketTagCheck : XRSocketInteractor
{
    public string targetTag = string.Empty;

    public override bool CanHover(IXRHoverInteractable interactable)// laat de hover zien in de socket van het object
    {
        return base.CanHover(interactable)
            && interactable is XRBaseInteractable baseInteractable
            && MatchUsingTag(baseInteractable);
    }

    public override bool CanSelect(IXRSelectInteractable interactable)// staat het item toe in de socket als er plek is
    {
        return base.CanSelect(interactable)
            && interactable is XRBaseInteractable baseInteractable
            && MatchUsingTag(baseInteractable);;
    }

    private bool MatchUsingTag(XRBaseInteractable interactable)// checkt de tag van het object in de socket
    {
        return interactable.CompareTag(targetTag);
    }
}