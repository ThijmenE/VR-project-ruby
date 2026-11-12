using UnityEngine;
using System.Collections;

public enum robotPersonality
{
    Happy,
    Enthusiastic,
    Sad,
    Scared
}

public class Robottext : MonoBehaviour
{
    public enum robotMinigame
    {
        Darten,
        Bowlen,
        Basketbal
    }

    private Coroutine robotDialogueCoroutine;

    public float praatCooldown = 15f;

    public void RobotCreated()// zegt een zin wanneer de robot gemaakt word
    {
        if (robotDialogueCoroutine != null)
        {
            StopCoroutine(robotDialogueCoroutine);
        }

        dialoguemanager dialogueManager = FindObjectOfType<dialoguemanager>();
        if (dialogueManager == null)
        {
            Debug.LogError("Cannot show dialogue UI because no dialogue manager exists in the scene.", this);
        }
        else
        {
            dialogueManager.showDialogue = true;
        }

        robotDialogueCoroutine = StartCoroutine(RobotPraten(praatCooldown));
    }

    public void RobotText()// Controleert of de robot een persoonlijkheid heeft en start vervolgens de introductie.
    {
        RobotButton robotButton = GetComponent<RobotButton>();
        if (robotButton == null)
        {
            Debug.LogError("Cannot show robot dialogue because this object has no RobotButton component.", this);
            return;
        }

        RobotIntroduction(robotButton.Personality);
    }

    private void RobotIntroduction(robotPersonality personality)// Kiest een willekeurige introductiezin op basis van de huidige persoonlijkheid van de robot.
    {
        string[] sentences = personality switch
        {
            robotPersonality.Happy => new[]
            {
                "Ik ben erg blij vandaag.",
                "Vandaag is een mooie dag.",
                "Dit wordt zo leuk!",
                "Dit is heel cool!",
                "Zullen we samenwerken?"
            },
            robotPersonality.Enthusiastic => new[]
            {
                "Ik ben erg enthousiast om je te helpen!",
                "Dit wordt erg leuk!",
                "Ik kan niet wachten om te beginnen!",
                "Dit ga je heel leuk vinden!",
                "Dit is het beste idee ooit!"
            },
            robotPersonality.Sad => new[]
            {
                "Ik voel me een beetje verdrietig vandaag.",
                "Deze dag is niet zo goed.",
                "Ik hoopte dat ik kon helpen.",
                "Soms ben ik niet goed genoeg.",
                "Ik hoop dat alles snel beter gaat."
            },
            robotPersonality.Scared => new[]
            {
                "Waar zijn we?",
                "Ik vindt deze plek eng",
                "Wat doen we hier?",
                "Ik ben bang.",
                "Zullen we hier weggaan?"
            },
            _ => throw new System.ArgumentOutOfRangeException(nameof(personality), personality, "Unknown robot personality.")
        };

        ToonZinInDialogueManager(sentences);
    }

    public void RobotPratenMinigames(robotMinigame minigame)// Start een willekeurige zin voor een specifieke minigame en herstart de rust-timer van de robot.
    {
        string[] minigameSentences = minigame switch
        {
            robotMinigame.Darten => GetDartenSentences(),
            robotMinigame.Bowlen => GetBowlenSentences(),
            robotMinigame.Basketbal => GetBasketbalSentences(),
            _ => new string[0]
        };

        if (robotDialogueCoroutine != null)
        {
            StopCoroutine(robotDialogueCoroutine);
            robotDialogueCoroutine = StartCoroutine(RobotPraten(praatCooldown));
        }

        ToonZinInDialogueManager(minigameSentences);
    }

    public void ScoreDarten()// Laat de robot reageren zodra alle drie de dartpijlen met succes in het bord zijn gegooid.
    {
        RobotPratenMinigames(robotMinigame.Darten);
    }

    public void ScoreBowlen(int aantalKegelsOm)// Controleert of er meer dan 5 kegels zijn omgegooid om de robot te laten praten.
    {
        if (aantalKegelsOm > 7)
        {
            RobotPratenMinigames(robotMinigame.Bowlen);
        }
    }

    public void ScoreBasketbal(int huidigeScore)// Controleert met de modulo-operator of de score door 5 te delen is.
    {
        if (huidigeScore > 0 && huidigeScore % 5 == 0)
        {
            RobotPratenMinigames(robotMinigame.Basketbal);
        }
    }

    private string[] GetDartenSentences()// Geeft een lijst met beschikbare zinnen voor de darten minigame terug.
    {
        return new[]
        {
            "Wat een goede worp!",
            "Haal zo veel mogelijk punten!",
            "Gooi de pijl voor scores!",
            "Wat een score!"
        };
    }

    private string[] GetBowlenSentences()// Geeft een lijst met beschikbare zinnen voor de bowlen minigame terug.
    {
        return new[]
        {
            "Wat zijn er veel kegels om!",
            "Je bent een goede bowler!",
            "Gooi ze allemaal om!",
            "Hoeveel punten heb je al gehaald?"
        };
    }

    private string[] GetBasketbalSentences()// Geeft een lijst met beschikbare zinnen voor de basketbal minigame terug.
    {
        return new[]
        {
            "Wat een goede worp!",
            "Hoeveel punten heb je al gehaald?",
            "Wow je hebt echt heel erg goed!",
            "Kun je het ook van een afstandje?"
        };
    }

    private void ToonZinInDialogueManager(string[] gekozenZinnen)// Kiest een willekeurige zin uit de meegegeven lijst en stuurt deze door naar de dialogue manager.
    {
        if (gekozenZinnen == null || gekozenZinnen.Length == 0) return;

        int randomIndex = Random.Range(0, gekozenZinnen.Length);
        string randomSentence = gekozenZinnen[randomIndex];

        dialoguemanager dialogueManager = FindObjectOfType<dialoguemanager>();
        if (dialogueManager == null)
        {
            Debug.LogError("Cannot show robot dialogue because no dialogue manager exists in the scene.", this);
            return;
        }

        dialogueManager.StartDialogue(randomSentence);
    }

    private IEnumerator RobotPraten(float delay)// Loop die na de cooldown automatisch de standaard robotText aanroept.
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            RobotText();
        }
    }
}
