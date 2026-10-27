using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrabTest : MonoBehaviour
{
    [SerializeField]
    private InputActionReference grabButton;
    [SerializeField] private Transform rightController;
    [SerializeField] private float maxGrabDistance;
    [SerializeField] private LayerMask grabbableLayer;

    private GameObject heldObject;

    private void OnEnable()
    {
        grabButton.action.performed += OnGrab;
        grabButton.action.canceled += OnRelease;
    }

    private void OnGrab(InputAction.CallbackContext context)
    {
        Ray ray = new Ray(rightController.transform.position, rightController.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxGrabDistance, grabbableLayer))
        {
            if (hit.collider != null)
            {
                heldObject = hit.collider.gameObject.GetComponentInParent<Rigidbody>().gameObject;
                heldObject.transform.SetParent(rightController);
                heldObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }
    

    private void OnRelease(InputAction.CallbackContext context)
    {
        heldObject.transform.SetParent(null);
        heldObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
