using UnityEngine;
using UnityEngine.UI;

public class dialoguemanager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public bool showDialogue;
    public GameObject robot;

    private Canvas dialogueCanvas;

    private void Awake()// verzamelt components in awake
    {
        if (dialogueText != null)
        {
            dialogueCanvas = dialogueText.GetComponentInParent<Canvas>();
        }

        if (dialogueCanvas == null && nameText != null)
        {
            dialogueCanvas = nameText.GetComponentInParent<Canvas>();
        }

        if (dialogueCanvas == null)
        {
            Debug.LogError("Cannot control dialogue UI because no Canvas was found for its text.", this);
            return;
        }

        dialogueCanvas.enabled = false;
    }

    private void Update()// laat het dialoog zien van de robot
    {
        if (showDialogue && dialogueCanvas != null && !dialogueCanvas.enabled)
        {
            ShowDialogue();
        }
    }

    public void StartDialogue(string sentence)// zorgt ervoor dat er een zin verschijnt op de canvas
    {
        ShowDialogue();

        if (nameText != null)
        {
            nameText.text = "Robot";
        }

        if (dialogueText != null)
        {
            dialogueText.text = sentence;
        }
    }

    public void EndDialogue()// maakt de tekst op de canvas leeg
    {
        if (dialogueText != null)
        {
            dialogueText.text = "";
        }

        Debug.Log("End of conversation");
    }

    public void ShowDialogue()// laat de canvas zien waar het dialoog op staat
    {
        showDialogue = true;
        if (dialogueCanvas != null)
        {
            dialogueCanvas.enabled = true;
        }
    }
}