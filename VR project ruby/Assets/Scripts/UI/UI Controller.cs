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

    public void StartGame() // laad een scene
    {
        SceneManager.LoadScene("Kamer");
    }

    public void StopGame() // sluit de game af
    {
        Application.Quit();
        Debug.Log("Stopping game");
    }

    public void NextCard() // laat het volgende kaart zien
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

    public void AudioSlider()// linkt de slider ingame aan het geluid van de audio
    {
        AudioListener.volume = audioSlider.value;
    }
}
