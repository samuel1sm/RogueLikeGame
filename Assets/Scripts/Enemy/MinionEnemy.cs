using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionEnemy : GenericEnemy
{


    private void Awake()
    {
        StartCoroutine(Movement());
        StartCoroutine(Attack());

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        isMoving = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isMoving = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isMoving = false;
    }

    protected override IEnumerator Movement()
    {
        while (true)
        {

            return new WaitUntil(() => isMoving);
        }
    }

    protected override IEnumerator Attack()
    {
        while (true)
        {
            return new WaitUntil(() => isAttacking);

        }
    }
}
