using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemIDCode
{
    Diamond=0,
    Sword,
    Armor,
    Potion,
    Shield,
    Potion_Mana
}

public enum EquipType
{
    LeftHand=0,
    RightHand,
    Armor,
    None,
    Use
}

public enum SkillType
{
    Attack=0,
    HolyBolt,
    BlessedHammer,
    Prayer,
    Vigor,
    Might,
    Holyfire,
    None

}

public enum Motion
{
    NoWeapon=0,
    SwordAndShield,
    TwinSword
   
}

public enum WeaponType
{
    None=0,
    Shield,
    Sword
}

public enum MonsterType
{
    beast=0,
    demon,
    undead
}
