using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏中的卡牌库
/// </summary>
public class SolitaireDB : Singleton<SolitaireDB>
{
    private int _maxIdx;

    private Dictionary<int, Solitaire> _data;

    public void Init()
    {
        _data = new Dictionary<int, Solitaire>();

        ///八副牌
        for (int i = 0; i < 8; i++)
        {
            ///每副13张
            for (int j = 0; j < 13; j++)
            {
                Solitaire so = new Solitaire(_maxIdx, (SolitaireLevel)j, (SolitaireColor)(i / 2));

                _data.Add(_maxIdx, so);

                _maxIdx++;

            }
        }
    }

    public Solitaire GetSolitaireByIdx(int idx)
    {
        return _data[idx];
    }

}
