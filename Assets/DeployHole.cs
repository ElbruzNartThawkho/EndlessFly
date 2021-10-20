using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployHole : MonoBehaviour
{
    public GameObject Hole;
    void Start()
    {
        StartCoroutine(Wave());
    }
    void Update()
    {

    }
    IEnumerator Wave()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            SpawnHole();
        }
    }
    private void SpawnHole()
    {
        GameObject H = Instantiate(Hole);
        H.transform.position = new Vector2(14, Random.Range(-4, 4));
    }
}
