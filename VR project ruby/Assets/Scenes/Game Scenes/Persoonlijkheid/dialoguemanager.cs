using UnityEngine;
using UnityEngine.UI;

public class dialoguemanager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public bool showDialogue = false;
    public GameObject robot;

    private Canvas dialogueCanvas;

    private void Awake()
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

        showDialogue = false;
        dialogueCanvas.gameObject.SetActive(false);
    }

    public void StartDialogue(string sentence)
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

    public void EndDialogue()
    {
        if (dialogueText != null)
        {
            dialogueText.text = "";
        }

        Debug.Log("End of conversation");
    }

    public void ShowDialogue()
    {
        showDialogue = true;

        if (dialogueCanvas != null)
        {
            dialogueCanvas.gameObject.SetActive(true);
        }
    }
}
