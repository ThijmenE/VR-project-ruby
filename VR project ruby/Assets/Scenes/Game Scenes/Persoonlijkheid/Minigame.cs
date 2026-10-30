using UnityEngine;

public class Minigame : MonoBehaviour
{
    public enum RobotMinigame
    {
        Darten,
        Bowlen,
        Basketbal
    }
    public void RobotPratenMinigames(RobotMinigame robotMinigame)
    {
        string[] minigameSentences = robotMinigame switch
        {
            RobotMinigame.Darten => new[]
            {
                "Wat een goede worp!",
                "Haal zo veel mogelijk punten!",
                "Gooi de pijl voor scores!",
                "Wat een score!"
            },
            RobotMinigame.Bowlen => new[]
            {
                "Wat zijn er veel kegels om!",
                "Je bent een goede bowler!",
                "Gooi ze allemaal om!",
                "Hoeveel punten heb je al gehaald?"
            },
            RobotMinigame.Basketbal => new[]
            {
                "Wat een goede worp!",
                "Hoeveel punten heb je al gehaald?",
                "Wow je hebt echt heel erg goed!",
                "Kun je het ook van een afstandje?"
            },
            _ => new string[0]
        };

        int randomIndex = Random.Range(0, minigameSentences.Length);
        string randomminigameSentence = minigameSentences[randomIndex];

        dialoguemanager dialogueManager = FindObjectOfType<dialoguemanager>();
        if (dialogueManager == null)
        {
            Debug.LogError("Cannot show robot dialogue because no dialogue manager exists in the scene.", this);
            return;
        }
    }
}
