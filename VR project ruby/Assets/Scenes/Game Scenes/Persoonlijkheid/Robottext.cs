using UnityEngine;

public enum RobotPersonality
{
    Happy,
    Enthusiastic,
    Sad,
    Scared
}

public class Robottext : MonoBehaviour
{
    public void RobotText()
    {
        RobotButton robotButton = GetComponent<RobotButton>();
        if (robotButton == null)
        {
            Debug.LogError("Cannot show robot dialogue because this object has no RobotButton component.", this);
            return;
        }

        RobotIntroduction(robotButton.Personality);
    }

    private void RobotIntroduction(RobotPersonality personality)
    {
        string[] sentences = personality switch
        {
            RobotPersonality.Happy => new[]
            {
                "I am very happy today.",
                "It is a good day today.",
                "This is going to be so much fun!",
                "This is so cool!",
                "We can work together!"
            },
            RobotPersonality.Enthusiastic => new[]
            {
                "I am so excited to help you!",
                "This is going to be amazing!",
                "I can't wait to get started!",
                "You're going to love this!",
                "This is the best idea ever!"
            },
            RobotPersonality.Sad => new[]
            {
                "I am feeling a bit down today.",
                "This situation is quite challenging.",
                "I wish I could be more helpful.",
                "Sometimes I feel like I'm not good enough.",
                "I hope things get better soon."
            },
            RobotPersonality.Scared => new[]
            {
                "What is this?",
                "It is a very scary day.",
                "What are we doing here?",
                "I am scared.",
                "Can we leave?"
            },
            _ => throw new System.ArgumentOutOfRangeException(nameof(personality), personality, "Unknown robot personality.")
        };

        int randomIndex = Random.Range(0, sentences.Length);
        string randomSentence = sentences[randomIndex];

        dialoguemanager dialogueManager = FindObjectOfType<dialoguemanager>();
        dialogueManager.StartDialogue(randomSentence);
    }
}