using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBow : RangeWeapon
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
        print("HelloThere");
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
