using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpwaner : MonoBehaviour
{
    public GameObject enemy;
    public int spwanTimer = 2;
    private void Start()
    {
        StartCoroutine(spwanEnemy());
    }

    IEnumerator spwanEnemy()
    {
        yield return new WaitForSeconds(spwanTimer);
        Instantiate(enemy, transform.position, Quaternion.identity);
        StartCoroutine(spwanEnemy());
    }
}
