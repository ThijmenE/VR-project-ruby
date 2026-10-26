using UnityEngine;
using System.Collections;
using TMPro;

public class Basketbalscore : MonoBehaviour
{
    private int score = 0;
    private bool isWaiting = false;

    public TextMeshProUGUI scoreText;

    private void Start()
    {
        UpdateScoreUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketbal") && !isWaiting)
        {
            score++;
            UpdateScoreUI();
            StartCoroutine(WaitAfterScore());
        }
    }

    private IEnumerator WaitAfterScore()
    {
        isWaiting = true;
        yield return new WaitForSeconds(1f);
        isWaiting = false;
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