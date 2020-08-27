using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public enum UICreateRoot
{   /// <summary>
    /// 最底层
    /// </summary>
    BackGround = 0,
    /// <summary>
    /// 纸牌层
    /// </summary>
    Default = 1,
    /// <summary>
    /// 效果层
    /// </summary>
    Effect = 2,
    /// <summary>
    /// 弹窗层
    /// </summary>
    Window = 3
}

public class UIManager : MonoSingleton<UIManager>
{
    private const string _objUrl = "Prefabs/UIManager";

    public new void Init()
    {
        transform.GetComponentInChildren<UI_GameRound>().StartGame();

        //GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(_objUrl));

        //go.transform.localPosition = Vector2.zero;

        //go.GetComponent<Canvas>().worldCamera = Camera.main;

        //transform = go.transform;
    }

    /// <summary>
    /// 注册和自身相关事件
    /// </summary>
    public void RegistEvent()
    {
        GameRoundManager.Instance.Onstart += CreateGameRoundUI;
    }

    public void CreateGameRoundUI()
    {
        //GameObject go = GameObject.Instantiate(UI_GameRound);

        //UI_GameRound rd = new UI_GameRound(go.transform);

        //CreateViewOnRoot(go);
    }


  
    public void CreateViewOnRoot(GameObject go, float destroyDelay = -1, UICreateRoot root = UICreateRoot.Default)
    {
        Transform parent = transform.GetChild((int)root);

        go.transform.SetParent(parent);
       
        go.transform.localScale = Vector2.one;

        go.transform.localPosition = Vector2.zero;

        go.GetComponent<RectTransform>().sizeDelta = parent.GetComponent<RectTransform>().sizeDelta;

    }
}
