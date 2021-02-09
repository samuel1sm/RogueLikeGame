using UnityEngine;

namespace Projectiles
{
    public class ArrowProjectile : GenericProjectile
    {
        // Start is called before the first frame update



        private void OnTriggerEnter2D(Collider2D collision)
        {

            transform.parent = collision.transform;
            transform.GetComponent<Collider2D>().enabled = false;
            transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Destroy(gameObject, 3);
     


        }
    }
}
