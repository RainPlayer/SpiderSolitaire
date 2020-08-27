using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 纸牌数字
/// </summary>
public enum SolitaireLevel
{
    SolitaireLevel_1 = 1,
    SolitaireLevel_2,
    SolitaireLevel_3,
    SolitaireLevel_4,
    SolitaireLevel_5,
    SolitaireLevel_6,
    SolitaireLevel_7,
    SolitaireLevel_8,
    SolitaireLevel_9,
    SolitaireLevel_10,
    SolitaireLevel_11,
    SolitaireLevel_12,
    SolitaireLevel_13,
}

/// <summary>
/// 纸牌颜色
/// </summary>
public enum SolitaireColor
{
    SolitaireColor_red,
    SolitaireColor_Green,
    SolitaireColor_Yellow,
    SolitaireColor_Blue,
}


/// <summary>
/// 纸牌数据
/// </summary>
public class Solitaire
{
    private int _idx;

    private SolitaireLevel _level;

    private SolitaireColor _color;

    public int GetIdx()
    {
        return _idx;
    }

    public SolitaireColor GetColor()
    {
        return _color;
    }

    public SolitaireLevel GetLevel()
    {
        return _level;
    }

    public Solitaire(int idx, SolitaireLevel level, SolitaireColor color)
    {
        _idx = idx;

        _level = level;

        _color = color;
    }

    /// <summary>
    /// 能否放在下方
    /// </summary>
    /// <param name="level"></param>
    /// <returns></returns>
    public bool CanPutInBottom(SolitaireLevel level)
    {
        if ((int)level - (int)_level == 1)
        {
            return true;
        }

        return false;
    }

}

