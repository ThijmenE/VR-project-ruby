using UnityEngine;

public class Prullenbak : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)// verwijdert objects met "Blok" tag op contact
    {
        if (other.CompareTag("Blok"))
        {
            Destroy(other.attachedRigidbody.gameObject);
        }
    }
}
