using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStaff : RangeWeapon
{
    public override void Attack()
    {
    }

    public override AnimatorOverrideController GetWeaponAnimations()
    {
        return weaponAnimations;
    }


    public override GameObject GetSelfObject()
    {
        return selfObject;
    }

 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Shoot(GameObject projectile, GameObject spawnPosition)
    {
        GameObject newProjectile = Instantiate(projectile, spawnPosition.transform.position, spawnPosition.transform.rotation);
        newProjectile.GetComponent<Rigidbody2D>().velocity = spawnPosition.gameObject.transform.right * projectileSpeed;
    }
}
