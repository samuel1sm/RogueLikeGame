using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackController : MonoBehaviour
{
    private Animator _animator;
    private GameObject projectile;
    [SerializeField] private Player player;

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


    public void Attack()
    {
        _animator.SetTrigger("isAttacking");
        GenericWeapon weapon = player.GetEquipedWeapon().GetComponent<GenericWeapon>();
        weapon.Attack();

    }

    public void Shoot()
    {
        RangeWeapon weapon = player.GetEquipedWeapon().GetComponent<RangeWeapon>();
        weapon.Shoot(weapon.GetProjectile(), projectile);
    }
}
