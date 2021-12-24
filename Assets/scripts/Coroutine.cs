using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public Transform SpawnPos;
    public Transform SpawnPos2;
    public GameObject Sphere;
    public int count=0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCD());
    }
    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(4);
        if (count == 0)
        {
            Instantiate(Sphere, SpawnPos.position, Quaternion.identity);
            count = 1;
        }
        else
        {
            Instantiate(Sphere, SpawnPos2.position, Quaternion.identity);
            count = 0;
        }
        Repeat();
    }
}
