using UnityEngine;
using TMPro;

public class Basketbalscore : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateScoreUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketbal"))
        {
            score++;
            UpdateScoreUI();
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}