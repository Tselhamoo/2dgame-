using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class enemystate : MonoBehaviour
{

Transform playerTarget;
    [SerializeField] private float speed = 5;
    SpriteRenderer spriteRenderer;
    Animator animatorController; // Add reference to Animator

    [SerializeField] private float chaseDistance = 3f;
    [SerializeField] private float attackDistance = 50f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animatorController = GetComponent<Animator>();
        playerTarget = GameObject.Find("doldol").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, playerTarget.position) <= chaseDistance)
        {
            chaseState();
        }
        else
        {
            idleState();
        }
    }

    //StateMachine
    void idleState()
    {
        //animatorController.SetInteger("enemyAni", 0);
    }
    void chaseState()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerTarget.position, speed * Time.deltaTime);

        // Check distance and set animation based on chase distance threshold
        float distanceToPlayer = Vector2.Distance(transform.position, playerTarget.position);
        //animatorController.SetInteger("enemyAni", 1);

        if (playerTarget.position.x < transform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, chaseDistance);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackDistance);
    }
}
