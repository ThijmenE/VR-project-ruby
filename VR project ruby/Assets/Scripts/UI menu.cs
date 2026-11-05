using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImenu : MonoBehaviour
{
    private bool card1Active;

    public void StartGame() // Loads a scene from the build profiles based on name
    {
        SceneManager.LoadScene("UI");
    }
}
