using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏进程生命周期
/// </summary>
public enum GameManagerLifeCircle
{
    /// <summary>
    /// 资源准备
    /// </summary>
    PrepareAsset,
    /// <summary>
    /// 初始化
    /// </summary>
    Init,



}

public class GameManager : MonoSingleton<GameManager>
{
    // Start is called before the first frame update
    void Start()
    {
        ///初始化数据
        SolitaireDB.Instance.Init();


        ///初始化ui
        UIManager.Instance.Init();

        GameRoundManager.Instance.Init();
    }

   
}
