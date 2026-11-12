using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImenu : MonoBehaviour
{
    private bool card1Active;

    public void StartGame() // laad een scene
    {
        SceneManager.LoadScene("UI");
    }
}
