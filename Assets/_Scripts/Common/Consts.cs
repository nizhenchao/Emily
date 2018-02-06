using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Consts
{
    // https://en.wikipedia.org/wiki/Machine_epsilon
    // pow(2, -24) -> 5.96e-08, magic minimal number
    public static readonly float Epsilon_Float = 5.96e-08f;

    public static readonly float Sprite_Gap_Time = 1.0f / 12.0f;

    public static readonly string Tk2dSprite_Not_Exist = "Tk2dSprite_Not_Exist";
    public static readonly string Tk2dSprite_Template = "tk2dSprite_template";

    public static readonly string ID_HERO_ARCHER = "heroes_archer";

    // Asset names
    public const string ASSET_NAME_CHARACTER = "character";

}