using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RangeWeapon : GenericWeapon
{
    [Header("Range Attributes")]
    [SerializeField] protected float projectileDuration;
    [SerializeField] protected float projectileSpeed;

    [SerializeField] protected GameObject projectile;

    public GameObject GetProjectile()
    {
        return projectile;
    }
}
