using System.Collections.Generic;
using UnityEngine;

public class basketbalreset : MonoBehaviour
{
    [SerializeField] private List<GameObject> basketBallen = new List<GameObject>();
    [SerializeField] private Basketbalscore basketbalScore;

    private List<objectStatus> itemsOpslaan = new List<objectStatus>();

    private void Start()
    {
        foreach (GameObject ball in basketBallen)
        {
            if (ball != null)
            {
                beginPos(ball);
            }
        }
    }

    private void beginPos(GameObject obj)
    {
        objectStatus status = new objectStatus
        {
            gameObject = obj,
            startPosition = obj.transform.position,
            startRotation = obj.transform.rotation,
            rigidbody = obj.GetComponent<Rigidbody>()
        };

        itemsOpslaan.Add(status);
    }

    public void resetGame()
    {
        foreach (objectStatus status in itemsOpslaan)
        {
            if (status.gameObject != null)
            {
                status.gameObject.transform.position = status.startPosition;
                status.gameObject.transform.rotation = status.startRotation;

                if (status.rigidbody != null)
                {
                    status.rigidbody.linearVelocity = Vector3.zero;
                    status.rigidbody.angularVelocity = Vector3.zero;
                    status.rigidbody.Sleep();
                }
            }
        }

        if (basketbalScore != null)
        {
            basketbalScore.ResetScore();
        }
    }

    [System.Serializable]
    private class objectStatus
    {
        public GameObject gameObject;
        public Vector3 startPosition;
        public Quaternion startRotation;
        public Rigidbody rigidbody;
    }
}