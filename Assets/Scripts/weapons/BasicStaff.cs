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

    public override void Shoot()
    {
        print("atirou 2");
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
