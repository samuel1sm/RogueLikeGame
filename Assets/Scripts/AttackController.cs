using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackController : MonoBehaviour
{
    private Animator _animator;
    private GameObject projectile;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        projectile = transform.GetChild(0).GetChild(0).gameObject;
    }


    public void SetAnimations(AnimatorOverrideController overrideController)
    {
        _animator.runtimeAnimatorController = overrideController;
    }


    public void ChangeWeapon(GenericWeapon weapon)
    {

        SetAnimations(weapon.GetWeaponAnimations());
    }


    public void Attack(GenericWeapon weapon)
    {
        _animator.SetTrigger("isAttacking");
        weapon.Attack();

    }

    public void Shoot()
    {
    }
}
