﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ProjectileType{
    ARROW, MAGIC
}

public enum WeaponType{
    SWORD, Spear, BOW, STAFF
}

public enum AttackType{
    RANGE, MELEE
}

public class UtilClass{

    public static Dictionary<WeaponType, AttackType> WeaponAttackTypes = new Dictionary<WeaponType, AttackType> { { WeaponType.SWORD, AttackType.MELEE },
        { WeaponType.Spear, AttackType.MELEE },{ WeaponType.BOW, AttackType.RANGE },{ WeaponType.STAFF, AttackType.RANGE } };
}


