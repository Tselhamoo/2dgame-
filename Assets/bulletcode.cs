using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcode : MonoBehaviour {

    void Start()
    {
        Invoke("DestoryGameObj", 2f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            collision.GetComponent<enemyhealth>().arrowHit();
            DestoryGameObj();
        }
    }

    void DestoryGameObj()
    {
        Destroy(gameObject);
    }

}
