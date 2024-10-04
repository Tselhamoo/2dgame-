using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class attacklogic : MonoBehaviour
{
    float timer = 0;
    public gamemanger gameM;

    private void OnTriggerStay2D(Collider2D collision)
    {
        timer += Time.deltaTime;
        Debug.Log("Timer : " + timer);
        if (collision.gameObject.tag == "Player" && (int) timer == 2)
        {
            gameM.PlayerHit(1);
            Debug.Log("Hit");
            timer = 0;
        } 
    }
}
