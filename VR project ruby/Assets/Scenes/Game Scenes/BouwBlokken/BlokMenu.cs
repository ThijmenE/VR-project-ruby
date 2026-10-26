using UnityEngine;
using UnityEngine.InputSystem;

public class BlokMenu : MonoBehaviour
{
    public GameObject blokMenu;
    private bool status = false;
    private InputAction yButtonAction;
    void Awake()
    {
        status = blokMenu.activeSelf;
    }

    void OnEnable()
    {
        yButtonAction = new InputAction(
            name: "Toggle Block Menu",
            type: InputActionType.Button,
            binding: "<XRController>{LeftHand}/secondaryButton");

        yButtonAction.performed += OnYButtonPressed;
        yButtonAction.Enable();
    }

    void OnDisable()
    {
        yButtonAction.performed -= OnYButtonPressed;
        yButtonAction.Dispose();
    }

    void OnYButtonPressed(InputAction.CallbackContext context)
    {
        BlokMenuSpawn();

    }

    public void BlokMenuSpawn()
    {
        status = !blokMenu.activeSelf;
        blokMenu.SetActive(status);
    }
}
