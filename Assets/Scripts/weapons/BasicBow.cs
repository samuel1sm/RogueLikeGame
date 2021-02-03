using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBow : RangeWeapon
{
    public override void Attack()
    {


    }


    public override GameObject GetSelfObject()
    {
        return selfObject;
    }

    public override AnimatorOverrideController GetWeaponAnimations()
    {
        return weaponAnimations;

    }

   

    public override void Shoot(GameObject projectile, GameObject spawnPosition)
    {
        GameObject newProjectile = Instantiate(projectile, spawnPosition.transform.position, spawnPosition.transform.rotation);
        newProjectile.GetComponent<Rigidbody2D>().velocity = spawnPosition.gameObject.transform.right * projectileSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
