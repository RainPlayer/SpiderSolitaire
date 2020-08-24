using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


/// <summary>
/// 游戏中的一个回合
/// </summary>
public class GameRoundManager : Singleton<GameRoundManager>
{
    private const int ColNum = 10;

    /// <summary>
    /// 每一列的卡牌数据
    /// </summary>
    private Dictionary<int, List<int>> _colSolitaires;
    /// <summary>
    /// 剩下的卡牌数据
    /// </summary>
    private List<int> _lastSolitaires;

    public event Action _Onstart;


    private const string _objUrl= "Prefabs/GameRound"; 


    public void Init()
    {
        _colSolitaires = new Dictionary<int, List<int>>();

        for (int i = 0; i < ColNum; i++)
        {
            _colSolitaires.Add(i, new List<int>());
        }

        _lastSolitaires = new List<int>();
    }

    /// <summary>
    /// 现在我们开始一局游戏
    /// </summary>
    public void StartGame()
    {
        _Onstart?.Invoke();
    }

    public static GameObject GetPrefabs()
    {
        return Resources.Load<GameObject>(_objUrl);
    }


}
