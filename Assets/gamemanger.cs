using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanger : MonoBehaviour
{

    [SerializeField] private float playerHealth = 10f;
    float damageTaken = 0;
    public healthsystem UIsystem;



    public void PlayerHit(float damage)
    {
        if (damageTaken < playerHealth)
        {
            damageTaken += damage;
            UIsystem.removeHealth((playerHealth - damageTaken) / playerHealth);
        }
        else
        {
            Debug.Log("Player Dead");
            Time.timeScale = 0f;
        }
    }

}

