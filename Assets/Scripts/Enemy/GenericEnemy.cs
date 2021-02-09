using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected float enemySpeed;
    [SerializeField] protected float enemyAttackDelay;
    [SerializeField] protected Rigidbody2D enemyRigidbody2D;

    protected GameObject player;
    protected bool isMoving = false;
    protected bool isAttacking = false;

    protected abstract IEnumerator Movement();
    protected abstract IEnumerator Attack();

}
