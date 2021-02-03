using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSpear : MeleeWeapon
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
