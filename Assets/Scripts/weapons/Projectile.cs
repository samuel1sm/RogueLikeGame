using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] ProjectileType type;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (type == ProjectileType.ARROW)
        {

            transform.parent = collision.transform;
            transform.GetComponent<Collider2D>().enabled = false;
            transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Destroy(gameObject, 3);
        }
        else
        {
            Destroy(gameObject);

        }


    }
}
