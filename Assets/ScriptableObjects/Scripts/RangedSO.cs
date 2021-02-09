using System.Collections;
using System.Collections.Generic;
using Projectiles;
using UnityEngine;
[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/Ranged", order = 1)]
public class RangedSO : WeaponSo
{
    // Start is called before the first frame update
    
    [Header("Range Attributes")]
    [SerializeField] public float projectileDuration;
    [SerializeField] public float projectileSpeed;
    [SerializeField] public GenericProjectile projectile;

    public void Shoot(GameObject spawnPosition)
    {
        var newProjectile = Instantiate(projectile, spawnPosition.transform.position, spawnPosition.transform.rotation);
        newProjectile.GetComponent<Rigidbody2D>().velocity = spawnPosition.gameObject.transform.right * projectileSpeed;
    }
}
