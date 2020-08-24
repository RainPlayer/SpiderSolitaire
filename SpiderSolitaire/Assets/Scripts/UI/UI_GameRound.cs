using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class UI_GameRound 
{
    public readonly Transform transform;

    /// <summary>
    /// 剩余卡牌区
    /// </summary>
    private Transform _lastCardArea;
    /// <summary>
    /// 操作卡牌区域
    /// </summary>
    private Transform _opeartionCardArea;


    public UI_GameRound(Transform trs)
    {
        transform = trs;

        _lastCardArea = transform.Find("last");

        _opeartionCardArea = transform.Find("col");
    }




}
