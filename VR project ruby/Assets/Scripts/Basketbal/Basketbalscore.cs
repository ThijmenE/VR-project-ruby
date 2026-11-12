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

    private void OnTriggerEnter(Collider other)// wanneer de tag van het object dat door de ring gaat "Basketbal" is runt de code in deze method
    {
        if (other.CompareTag("Basketbal") && !isWaiting)
        {
            score++;
            UpdateScoreUI();
            CheckBasketbalScore();
            StartCoroutine(WaitAfterScore());
        }
    }

    private IEnumerator WaitAfterScore()// seconde cooldown tussen punten scoren
    {
        isWaiting = true;
        yield return new WaitForSeconds(1f);
        isWaiting = false;
    }

    private void UpdateScoreUI()// update de UI om 1 punt toe te voegen
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void ResetScore()// zet de score op 0
    {
        score = 0;
        UpdateScoreUI();
    }

    public void CheckBasketbalScore()// elke 5 punten in basketbal zegt de robot iets tegen je
    {
        if (score > 0 && score % 5 == 0)
        {
            Robottext robotText = FindObjectOfType<Robottext>();
            robotText.ScoreBasketbal(score);
        }
    }
}