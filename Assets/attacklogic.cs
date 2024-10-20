using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class attacklogic : MonoBehaviour
{
   
    float timer = 0;
    gamemanger gameM;
    public float damage = 5f;

    private void Start()
    {
        gameM = FindAnyObjectByType<gamemanger>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            timer += Time.deltaTime;
            Debug.Log("Timer : " + timer);

            if ((int)timer == 2)
            {
                gameM.PlayerHit(damage);
                Debug.Log("Hit");
                timer = 0;

            }
        }
    }
}
