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
    private int[] _lastSolitaires;

    /// <summary>
    /// 当游戏开始
    /// </summary>
    public event Action Onstart;

    /// <summary>
    /// 当剩下的卡牌数量发生变化,因为剩下的卡牌发生变化一定是发牌，所以这里只写一个事件
    /// </summary>
    public event Action<int> OnDealCard;


    private const string _objUrl= "Prefabs/GameRound"; 


    public void Init()
    {
        _colSolitaires = new Dictionary<int, List<int>>();

        for (int i = 0; i < ColNum; i++)
        {
            _colSolitaires.Add(i, new List<int>());
        }

        int num = SolitaireDB.Instance.GetSolitaireCount();

        _lastSolitaires = new int[num];

        for (int i = 0; i < num; i++)
        {
            _lastSolitaires[i] = num;
        }

    }

    /// <summary>
    /// 发牌
    /// </summary>
    public void DealCard()
    {

    }

    /// <summary>
    /// 洗牌
    /// </summary>
    public void ShuffleCard()
    {
        for (int i = 0; i < _lastSolitaires.Length; i++)
        {
            int random = UnityEngine.Random.Range(i, _lastSolitaires.Length);

            int temp = _lastSolitaires[i];

            _lastSolitaires[i] = _lastSolitaires[random];

            _lastSolitaires[random] = temp;
        }
    }




    /// <summary>
    /// 现在我们开始一局游戏
    /// </summary>
    public void StartGame()
    {
        Onstart?.Invoke();
    }

    public static GameObject GetPrefabs()
    {
        return Resources.Load<GameObject>(_objUrl);
    }


}
