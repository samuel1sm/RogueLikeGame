using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericWeapon : MonoBehaviour
{
    [Header ("Generic Attributes")]
    [SerializeField] protected float attackQtd;
    [SerializeField] protected float weaponDamage;
    [SerializeField] protected float attackDelay;
    [SerializeField] protected WeaponType weaponType;
    [SerializeField] protected AttackType AttackType;
    [SerializeField] protected AnimatorOverrideController weaponAnimations;
    [SerializeField] protected GameObject selfObject;
    public abstract void Attack();
    // Start is called before the first frame update

    public abstract void Shoot(GameObject projectile, GameObject spawnPosition);

    public abstract AnimatorOverrideController GetWeaponAnimations();
    public abstract GameObject GetSelfObject();


}
