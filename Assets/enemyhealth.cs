using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public int numofArwTokill = 4;
    int numofArwTaken = 1;
    gamemanger gameGM;

    private void Start()
    {
        gameGM = FindAnyObjectByType<gamemanger>();
    }

    public void arrowHit()
    {
        if (numofArwTokill > numofArwTaken)
        {
            numofArwTaken++;

        }
        else
        {
            gameGM.AddKills();
            Destroy(gameObject);
        }
    }
}
