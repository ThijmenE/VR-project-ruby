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

    public void SpawnButton1x1()// laat de 1x1 knop werken in het blok menu UI en gaat op een seconde cooldown zodat er niet te veel ineens geplaats kan worden
    {
        if (isSpawning) return;

        StartCoroutine(SpawnBlok1x1());
    }

    public void SpawnButton1x2()// laat de 1x2 knop werken in het blok menu UI en gaat op een seconde cooldown zodat er niet te veel ineens geplaats kan worden
    {
        if (isSpawning) return;

        StartCoroutine(SpawnBlok1x2());
    }

    public void SpawnButton2x2()// laat de 2x2 knop werken in het blok menu UI en gaat op een seconde cooldown zodat er niet te veel ineens geplaats kan worden
    {
        if (isSpawning) return;

        StartCoroutine(SpawnBlok2x2());
    }

    IEnumerator SpawnBlok1x1()// plaatst een 1x1 blok voor je karakter neer
    {
        isSpawning = true;

        Instantiate(blok1x1, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(1);

        isSpawning = false;
    }

    IEnumerator SpawnBlok1x2()// plaatst een 1x2 blok voor je karakter neer
    {
        isSpawning = true;

        Instantiate(blok1x2, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(1);

        isSpawning = false;
    }

    IEnumerator SpawnBlok2x2()// plaatst een 2x2 blok voor je karakter neer
    {
        isSpawning = true;

        Instantiate(blok2x2, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(1);

        isSpawning = false;
    }

    void OnDisable()//tijdens de cooldown kan je niet een blok plaatsen
    {
        isSpawning = false;
    }
}
