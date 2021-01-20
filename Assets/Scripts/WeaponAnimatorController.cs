using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class WeaponAnimatorController : MonoBehaviour
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

        public Animator GetAnimator()
        {
            return _animator;
        }
}

