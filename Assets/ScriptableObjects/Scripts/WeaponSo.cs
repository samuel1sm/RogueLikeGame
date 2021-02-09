using UnityEngine;



public abstract class WeaponSo : ScriptableObject
{
    [SerializeField] public float attackDelay;
    [SerializeField] public Sprite weaponSprite;
    [SerializeField] public float damage;
    [SerializeField] public WeaponType weaponType;
    [SerializeField] public AttackType attackType;
    [SerializeField] public AnimatorOverrideController weaponAnimations;
    [SerializeField] public GameObject collectablePrefab;
    public void Attack()
    {
    }
}
