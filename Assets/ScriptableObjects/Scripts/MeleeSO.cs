using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/Melee", order = 1)]
    public class MeleeSO : WeaponSo
    {
        [SerializeField] public float attackDistance;

    }
}
