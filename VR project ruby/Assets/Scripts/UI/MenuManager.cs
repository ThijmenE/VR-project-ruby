using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    public GameObject blokMenu;
    public GameObject menu;
    public GameObject uitleg;
    private bool blokStatus;
    private bool menuStatus;
    private bool uitlegStatus;
    private InputAction yButtonAction;
    private InputAction xButtonAction;
    private InputAction menuButtonAction;
    void Awake()// slaat de status op van de bools
    {
        blokStatus = blokMenu.activeSelf;
        menuStatus = menu.activeSelf;
        uitlegStatus = uitleg.activeSelf;
    }

    void OnEnable()// kijkt naar de input, opent een menu en sluit andere menus af (als er een menu open is)
    {
        yButtonAction = new InputAction(
            name: "Toggle Block Menu",
            type: InputActionType.Button,
            binding: "<XRController>{LeftHand}/secondaryButton");

        yButtonAction.performed += OnYButtonPressed;
        yButtonAction.Enable();

        xButtonAction = new InputAction(
            name: "Toggle Uitleg Menu",
            type: InputActionType.Button,
            binding: "<XRController>{LeftHand}/primaryButton");

        xButtonAction.performed += OnXButtonPressed;
        xButtonAction.Enable();

        menuButtonAction = new InputAction(
            name: "Toggle Menu",
            type: InputActionType.Button,
            binding: "<XRController>{LeftHand}/{menuButton}");

        menuButtonAction.performed += OnMenuButtonPressed;
        menuButtonAction.Enable();
    }

    void OnDisable()// sluit menu af
    {
        yButtonAction.performed -= OnYButtonPressed;
        yButtonAction.Dispose();

        xButtonAction.performed -= OnXButtonPressed;
        xButtonAction.Dispose();

        menuButtonAction.performed -= OnMenuButtonPressed;
        menuButtonAction.Dispose();
    }

    void OnYButtonPressed(InputAction.CallbackContext context)// laat menu verschijnen met Y knop
    {
        BlokMenuSpawn();
    }

       void OnXButtonPressed(InputAction.CallbackContext context)// laat menu verschijnen met X knop
    {
        UitlegSpawn();
    }

    void OnMenuButtonPressed(InputAction.CallbackContext context)// laat menu verschijnen met menu knop
    {
        MenuSpawn();
    }

    public void BlokMenuSpawn()// laat het blokmenu verschijnen
    {
        if (menuStatus == true || uitlegStatus == true)
        {
            menuStatus = false;
            menu.SetActive(menuStatus);
            uitlegStatus = false;
            uitleg.SetActive(uitlegStatus);

            blokStatus = !blokMenu.activeSelf;
            blokMenu.SetActive(blokStatus);
        }
        else
        {
            blokStatus = !blokMenu.activeSelf;
            blokMenu.SetActive(blokStatus);
        }
    }

    public void MenuSpawn()// laat het menu verschijnen
    {
        if (blokStatus == true || uitlegStatus == true)
        {
            
            uitlegStatus = false;
            uitleg.SetActive(uitlegStatus);
            blokStatus = false;
            blokMenu.SetActive(blokStatus);

            menuStatus = !menu.activeSelf;
            menu.SetActive(menuStatus);
        }
        else
        {
            menuStatus = !menu.activeSelf;
            menu.SetActive(menuStatus);
        }
    }

        public void UitlegSpawn()// laat de uitleg verschijnen
    {
        if (blokStatus == true || menuStatus == true)
        {
            blokStatus = false;
            blokMenu.SetActive(blokStatus);
            menuStatus = false;
            menu.SetActive(menuStatus);

            uitlegStatus = !uitleg.activeSelf;
            uitleg.SetActive(uitlegStatus);
        }
        else
        {
            uitlegStatus = !uitleg.activeSelf;
            uitleg.SetActive(uitlegStatus);
        }
    }
}
