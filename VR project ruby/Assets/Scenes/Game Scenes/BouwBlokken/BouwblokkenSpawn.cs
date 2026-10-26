using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.UI;

public class BouwBlokkenSpawn : MonoBehaviour
{
    [SerializeField] private GameObject blok1x1;
    [SerializeField] private GameObject blok1x2;
    [SerializeField] private GameObject blok2x2;

    public bool isSpawning = false;

    public void SpawnButton1x1()
    {
        if (isSpawning) return;

        StartCoroutine(SpawnBlok1x1());
    }

    public void SpawnButton1x2()
    {
        if (isSpawning) return;

        StartCoroutine(SpawnBlok1x2());
    }

    public void SpawnButton2x2()
    {
        if (isSpawning) return;

        StartCoroutine(SpawnBlok2x2());
    }

    IEnumerator SpawnBlok1x1()
    {
        isSpawning = true;

        Instantiate(blok1x1, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(1);

        isSpawning = false;
    }

    IEnumerator SpawnBlok1x2()
    {
        isSpawning = true;

        Instantiate(blok1x2, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(1);

        isSpawning = false;
    }

    IEnumerator SpawnBlok2x2()
    {
        isSpawning = true;

        Instantiate(blok2x2, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(1);

        isSpawning = false;
    }

    void OnDisable()
    {
        isSpawning = false;
    }
}
