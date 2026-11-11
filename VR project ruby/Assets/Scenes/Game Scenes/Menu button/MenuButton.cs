using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private Slider audioSlider;
    [SerializeField] private AudioSource audioSource;


    public void StopGame() // closes the game when a build has been made
    {
        Application.Quit();
        Debug.Log("Stopping game");
    }

    public void AudioSlider()
    {
        AudioListener.volume = audioSlider.value;
    }
}
