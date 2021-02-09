using UnityEngine;

namespace weapons.GenericTypes
{
    [RequireComponent(typeof(SpriteRenderer), typeof(Collider2D))]
    public class CollectableWeapon : MonoBehaviour
    {
        [SerializeField] private WeaponSo weaponSo;

        public WeaponSo GetItemSo()
        {
            return weaponSo;
        }
    }
}
