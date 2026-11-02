using UnityEngine;
using System.Collections;

public enum RobotPersonality
{
    Happy,
    Enthusiastic,
    Sad,
    Scared
}

public class Robottext : MonoBehaviour
{
    public enum RobotMinigame
    {
        Darten,
        Bowlen,
        Basketbal
    }

    private Coroutine robotDialogueCoroutine;

    public float praatCooldown = 15f;

    // Start of reset de herhalende timer die de robot om de zoveel seconden laat praten.
    public void RobotCreated()
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
            dialogueManager.ShowDialogue();
        }

        robotDialogueCoroutine = StartCoroutine(RobotPraten(praatCooldown));
    }

    // Controleert of de robot een persoonlijkheid heeft en start vervolgens de introductie.
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

    // Kiest een willekeurige introductiezin op basis van de huidige persoonlijkheid van de robot.
    private void RobotIntroduction(RobotPersonality personality)
    {
        string[] sentences = personality switch
        {
            RobotPersonality.Happy => new[]
            {
                "Ik ben erg blij vandaag.",
                "Vandaag is een mooie dag.",
                "Dit wordt zo leuk!",
                "Dit is heel cool!",
                "Zullen we samenwerken?"
            },
            RobotPersonality.Enthusiastic => new[]
            {
                "Ik ben erg enthousiast om je te helpen!",
                "Dit wordt erg leuk!",
                "Ik kan niet wachten om te beginnen!",
                "Dit ga je heel leuk vinden!",
                "Dit is het beste idee ooit!"
            },
            RobotPersonality.Sad => new[]
            {
                "Ik voel me een beetje verdrietig vandaag.",
                "Deze dag is niet zo goed.",
                "Ik hoopte dat ik kon helpen.",
                "Soms ben ik niet goed genoeg.",
                "Ik hoop dat alles snel beter gaat."
            },
            RobotPersonality.Scared => new[]
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

    // Start een willekeurige zin voor een specifieke minigame en herstart de rust-timer van de robot.
    public void RobotPratenMinigames(RobotMinigame minigame)
    {
        string[] minigameSentences = minigame switch
        {
            RobotMinigame.Darten => GetDartenSentences(),
            RobotMinigame.Bowlen => GetBowlenSentences(),
            RobotMinigame.Basketbal => GetBasketbalSentences(),
            _ => new string[0]
        };

        if (robotDialogueCoroutine != null)
        {
            StopCoroutine(robotDialogueCoroutine);
            robotDialogueCoroutine = StartCoroutine(RobotPraten(praatCooldown));
        }

        ToonZinInDialogueManager(minigameSentences);
    }

    // Laat de robot reageren zodra alle drie de dartpijlen met succes in het bord zijn gegooid.
    public void ScoreDarten()
    {
        RobotPratenMinigames(RobotMinigame.Darten);
    }

    // Controleert of er meer dan 5 kegels zijn omgegooid om de robot te laten praten.
    public void ScoreBowlen(int aantalKegelsOm)
    {
        if (aantalKegelsOm > 7)
        {
            RobotPratenMinigames(RobotMinigame.Bowlen);
        }
    }

    // Controleert met de modulo-operator of de score door 5 te delen is.
    public void ScoreBasketbal(int huidigeScore)
    {
        if (huidigeScore > 0 && huidigeScore % 5 == 0)
        {
            RobotPratenMinigames(RobotMinigame.Basketbal);
        }
    }

    // Geeft een lijst met beschikbare zinnen voor de darten minigame terug.
    private string[] GetDartenSentences()
    {
        return new[]
        {
            "Wat een goede worp!",
            "Haal zo veel mogelijk punten!",
            "Gooi de pijl voor scores!",
            "Wat een score!"
        };
    }

    // Geeft een lijst met beschikbare zinnen voor de bowlen minigame terug.
    private string[] GetBowlenSentences()
    {
        return new[]
        {
            "Wat zijn er veel kegels om!",
            "Je bent een goede bowler!",
            "Gooi ze allemaal om!",
            "Hoeveel punten heb je al gehaald?"
        };
    }

    // Geeft een lijst met beschikbare zinnen voor de basketbal minigame terug.
    private string[] GetBasketbalSentences()
    {
        return new[]
        {
            "Wat een goede worp!",
            "Hoeveel punten heb je al gehaald?",
            "Wow je hebt echt heel erg goed!",
            "Kun je het ook van een afstandje?"
        };
    }

    // Kiest een willekeurige zin uit de meegegeven lijst en stuurt deze door naar de dialogue manager.
    private void ToonZinInDialogueManager(string[] gekozenZinnen)
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

    // Loop die na de cooldown automatisch de standaard robotText aanroept.
    private IEnumerator RobotPraten(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            RobotText();
        }
    }
}
