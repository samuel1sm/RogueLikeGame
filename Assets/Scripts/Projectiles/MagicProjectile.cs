using UnityEngine;

namespace Projectiles
{
    public class MagicProjectile : GenericProjectile
    {


        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(gameObject);
        }
    }
}
