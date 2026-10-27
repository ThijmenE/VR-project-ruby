using UnityEngine;
using UnityEngine.UI;

public class dialoguemanager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public void StartDialogue(string sentence)
    {
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
}
