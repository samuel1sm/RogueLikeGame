using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSword : MeleeWeapon
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
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update

}
