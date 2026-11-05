using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject card1;
    [SerializeField] private GameObject card2;
    [SerializeField] private Slider audioSlider;
    [SerializeField] private AudioSource audioSource;

    private bool card1Active;

    public void StartGame() // Loads a scene from the build profiles based on name
    {
        SceneManager.LoadScene("Kamer");
    }

    public void StopGame() // closes the game when a build has been made
    {
        Application.Quit();
        Debug.Log("Stopping game");
    }

    public void NextCard() // enables and disables the active cards in the menu scene
    {
        if (card1 == null || card2 == null)
        {
            Debug.LogWarning("Assign card1 and card2 in the Inspector before using NextCard.");
            return;
        }

        card1Active = !card1Active;
        card1.SetActive(card1Active);
        card2.SetActive(!card1Active);
    }

    public void AudioSlider()
    {
        AudioListener.volume = audioSlider.value;
    }
}
