using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


/// <summary>
/// 角色類型。無類型=0，玩家角色1，怪物2，NPC 3。
/// </summary>
public enum CharacterType { None, Player, Monster, NPC }

public abstract class Character
{
    /// <summary>
    /// 角色分類。
    /// </summary>
    internal CharacterType CharacterType;
    /// <summary>
    /// 名稱。
    /// </summary>
    internal string sName;

    //屬性質
    /// <summary>
    /// 智力
    /// </summary>
    internal int iInt { get; protected set; }
    /// <summary>
    /// 力量
    /// </summary>
    internal int iStr { get; protected set; }
    /// <summary>
    /// 敏捷
    /// </summary>
    internal int iDex { get; protected set; }
    /// <summary>
    /// 耐力
    /// </summary>
    internal int iSta { get; protected set; }
    /// <summary>
    /// 社交
    /// </summary>
    internal int iSoc { get; protected set; }

    //值域類
    /// <summary>
    /// 目前HP值。
    /// </summary>
    internal int iCurrentHP;
    /// <summary>
    /// 最大HP值。
    /// </summary>
    internal int iMaxHP { get; protected set; }

    /// <summary>
    /// 目前SP值。
    /// </summary>
    internal int iCurrentSP;
    /// <summary>
    /// 最大SP值。
    /// </summary>
    internal int iMaxSP { get; protected set; }

    //狀態類
    /// <summary>
    /// 硬直或暈眩。
    /// </summary>
    internal bool bIsStun = false;
    /// <summary>
    /// 處於無法動作的動畫中。
    /// </summary>
    internal bool bIsAnimating = false;
}

