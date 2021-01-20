using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum WeaponType{
    SWORD, LANCE, BOW, STAFF
}

public enum AttackType{
    RANGE, MELEE
}

public class UtilClass{

    public static Dictionary<WeaponType, AttackType> WeaponAttackTypes = new Dictionary<WeaponType, AttackType> { { WeaponType.SWORD, AttackType.MELEE },
        { WeaponType.LANCE, AttackType.MELEE },{ WeaponType.BOW, AttackType.RANGE },{ WeaponType.STAFF, AttackType.RANGE } };
}


