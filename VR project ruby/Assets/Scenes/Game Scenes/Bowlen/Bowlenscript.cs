using System.Collections.Generic;
using UnityEngine;

public class Bowlenscript : MonoBehaviour
{
    private const float FallenPinAngle = 45f;

    [SerializeField] private List<GameObject> pins = new List<GameObject>();
    [SerializeField] private GameObject BowlingBal;

    private List<ObjectStatus> ItemsOpslaan = new List<ObjectStatus>();
    private bool bowlingLinePlayed;

    void Start()
    {
        if (BowlingBal != null)
        {
            BeginPos(BowlingBal);
        }

        foreach (GameObject pin in pins)
        {
            if (pin != null)
            {
                BeginPos(pin);
            }
        }
    }

    private void Update()
    {
        int fallenPins = 0;

        foreach (ObjectStatus status in ItemsOpslaan)
        {
            if (status.gameObject != null &&
                Quaternion.Angle(status.startRotation, status.gameObject.transform.rotation) >= FallenPinAngle)
            {
                fallenPins++;
            }
        }

        CheckBowlenScore(fallenPins);
    }

    void BeginPos(GameObject obj)
    {
        ObjectStatus status = new ObjectStatus
        {
            gameObject = obj,
            startPosition = obj.transform.position,
            startRotation = obj.transform.rotation,
            rigidbody = obj.GetComponent<Rigidbody>()
        };

        ItemsOpslaan.Add(status);
    }

    public void ResetGame()
    {
        bowlingLinePlayed = false;

        foreach (ObjectStatus status in ItemsOpslaan)
        {
            if (status.gameObject != null)
            {
                status.gameObject.transform.position = status.startPosition;
                status.gameObject.transform.rotation = status.startRotation;

                if (status.rigidbody != null)
                {
                    status.rigidbody.linearVelocity = Vector3.zero;
                    status.rigidbody.angularVelocity = Vector3.zero;
                }
            }
        }
    }

    public void CheckBowlenScore(int score)
    {
        if (score > 7 && !bowlingLinePlayed)
        {
            bowlingLinePlayed = true;
            Robottext robotText = FindObjectOfType<Robottext>();
            robotText.ScoreBowlen(score);
        }
    }

    [System.Serializable]
    private class ObjectStatus
    {
        public GameObject gameObject;
        public Vector3 startPosition;
        public Quaternion startRotation;
        public Rigidbody rigidbody;
    }
}