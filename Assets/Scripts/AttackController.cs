using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using weapons.GenericTypes;


public class AttackController : MonoBehaviour
{
    private Animator _animator;
    private GameObject _projectile;
    [SerializeField] private Player player;

    private void Awake()
    {
        player.OnWeaponChanged += ChangeWeapon;
        _animator = GetComponent<Animator>();
        _projectile = transform.GetChild(0).GetChild(0).gameObject;
    }


    public void SetAnimations(AnimatorOverrideController overrideController)
    {
        _animator.runtimeAnimatorController = overrideController;
    }


    public void ChangeWeapon(WeaponSo weapon)
    {

        SetAnimations(weapon.weaponAnimations);
    }


    public void Attack()
    {
        _animator.SetTrigger("isAttacking");
        var weapon = player.GetEquipedWeapon();
        weapon.Attack();

    }

    public void Shoot()
    {
        var weapon =  player.GetEquipedWeapon() as RangedSO;
        weapon.Shoot(_projectile);
    }
}
