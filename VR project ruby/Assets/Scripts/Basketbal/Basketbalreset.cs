using System.Collections.Generic;
using UnityEngine;

public class basketbalreset : MonoBehaviour
{
    [SerializeField] private List<GameObject> basketBallen = new List<GameObject>();
    [SerializeField] private Basketbalscore basketBalScore;

    private List<objectStatus> itemsOpslaan = new List<objectStatus>();

    private void Start() //als er objects in de lijst staan runt hij het script
    {
        foreach (GameObject ball in basketBallen)
        {
            if (ball != null)
            {
                beginPos(ball);
            }
        }
    }

    private void beginPos(GameObject obj) //verzamelt de locatie van elk object in de lijst
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

    public void resetGame()// reset alle objects in de lijst naar hun begin locatie
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

        if (basketBalScore != null)
        {
            basketBalScore.ResetScore();
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