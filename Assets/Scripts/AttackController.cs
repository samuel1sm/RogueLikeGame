using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackController : MonoBehaviour
{
    [SerializeField] private GenericWeapon[] weapons = new GenericWeapon[2];
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


    public void ChangeWeapon(int i)
    {
        SetAnimations(weapons[i].GetWeaponAnimations());
    }


    public void Attack(int i)
    {

        _animator.SetTrigger("isAttacking");
        weapons[i].Attack();

    }

    public void Shoot()
    {
        print("HelloThere");
    }
}
