using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private AnimatorOverrideController[] overrideControllers;
    private WeaponAnimatorOverrider overrider;
    Animator attackController;
    private void Awake()
    {
        overrider = GetComponent<WeaponAnimatorOverrider>();
        attackController = GetComponent<Animator>();
    }

    public void Set(int value)
    {
        overrider.SetAnimations(overrideControllers[value]);
    }


    public void Attack()
    {
        attackController.SetTrigger("isAttacking");
    }
}
