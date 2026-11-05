using UnityEngine;

public class Prullenbak : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blok"))
        {
            Destroy(other.attachedRigidbody.gameObject);
        }
    }
}
