using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    public void Init()
    {
        _colSolitaires = new Dictionary<int, List<int>>();

        for (int i = 0; i < ColNum; i++)
        {
            _colSolitaires.Add(i, new List<int>());
        }

        _lastSolitaires = new List<int>();

        UIManager.Instance.CreateCard(SolitaireDB.Instance.GetSolitaireByIdx(5));

    }





}
