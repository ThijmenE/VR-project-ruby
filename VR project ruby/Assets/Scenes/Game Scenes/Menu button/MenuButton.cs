using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private Slider audioSlider;
    [SerializeField] private AudioSource audioSource;


    public void LoadMenu() // Loads a scene from the build profiles based on name
    {
        // SceneManager.LoadScene(sceneName);
        Debug.Log("loading scene");
    }

    public void AudioSlider()
    {
        AudioListener.volume = audioSlider.value;
    }
}
