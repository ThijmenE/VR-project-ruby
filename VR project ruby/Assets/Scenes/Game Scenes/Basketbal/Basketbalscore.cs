using UnityEngine;
using TMPro;

public class Basketbalscore : MonoBehaviour
{
    private int score = 0;

    public TextMeshProUGUI scoreText;

    private void Start()
    {
        UpdateScoreUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketbal"))
        {
            score++;
            UpdateScoreUI();
        }
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreUI();
    }
}