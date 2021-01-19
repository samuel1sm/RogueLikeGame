using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class WeaponAnimatorOverrider : MonoBehaviour
    {
        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void SetAnimations( AnimatorOverrideController overrideController)
        {
        _animator.runtimeAnimatorController = overrideController;
        }
    }

