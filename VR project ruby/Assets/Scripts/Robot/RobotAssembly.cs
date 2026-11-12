using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RobotAssembly : MonoBehaviour
{
    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;
    public bool isActive { get; private set; }
    public MeshFilter currentMeshFilter { get; private set; }

    void Awake()// pakt een component van de XR socket ineractor
    {
        socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();
    }

    void Update()// zet de meshes en materials over van de object die in de sockets zitten
    {
        if (socket == null) return;

        UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable currentInteractable =
            socket.interactablesSelected.Count > 0 ? socket.interactablesSelected[0] : null;

        if (currentInteractable != null)
        {
            GameObject obj = currentInteractable.transform.gameObject;
            Debug.Log($"Object in {this.name}: {obj.name}");
            isActive = true;
            currentMeshFilter = obj.GetComponentInChildren<MeshFilter>(true);
        }
        else
        {
            Debug.Log(this.name + " is empty.");
            isActive = false;
            currentMeshFilter = null;
        }
    }
}
