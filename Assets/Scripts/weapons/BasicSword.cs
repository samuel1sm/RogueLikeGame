using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSword : MeleeWeapon
{
    public override void Attack()
    {
        print("attacked " + weaponType);
    }

    public override AnimatorOverrideController GetWeaponAnimations()
    {
        return weaponAnimations;
    }

    public override void Shoot()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
 
}
