using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class UI_GameRound:MonoBehaviour
{
    /// <summary>
    /// 剩余卡牌区
    /// </summary>
    public Transform _lastCardArea;
    /// <summary>
    /// 操作卡牌区域
    /// </summary>
    public Transform _opeartionCardArea;

    public UI_Card _cell;

    public void StartGame()
    {
        GameRoundManager.Instance.Init();

        //_lastCardArea = transform.Find("last");

        //_opeartionCardArea = transform.Find("col");

        RefreshLastCards(GameRoundManager.Instance.GetLastSolitaireCount());
    }



    /// <summary>
    /// 刷新剩余区域
    /// </summary>
    public void RefreshLastCards(int lastNum)
    {
        if (_lastCardArea.childCount>lastNum)
        {
            for (int i = lastNum-1; i < _lastCardArea.childCount; i++)
            {
                GameObject.Destroy(_lastCardArea.GetChild(i));
            }
        }

        for (int i = 0; i < lastNum; i++)
        {
            if (_lastCardArea.childCount<=i)
            {
                Instantiate(_cell, _lastCardArea);
            }
        }
    }

    /// <summary>
    /// 生成卡牌
    /// </summary>
    public void CreateCard()
    {
     

    }

}
