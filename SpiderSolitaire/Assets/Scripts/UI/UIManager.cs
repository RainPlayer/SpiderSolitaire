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

public class UIManager : Singleton<UIManager>
{
    public Transform transform;

    private const string _objUrl = "Prefabs/UIManager";

    public void Init()
    {
        GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(_objUrl));

        go.transform.localPosition = Vector2.zero;

        go.GetComponent<Canvas>().worldCamera = Camera.main;

        transform = go.transform;
    }

    public void CreateCard(Solitaire so)
    {
        GameObject go= GameObject.Instantiate(Solitaire.GetPrefabs());

        go.transform.SetParent(transform.GetChild(1));

        Transform trs = go.transform;

        trs.localPosition = Vector2.zero;

        trs.localScale = Vector2.one;

        trs.Find("bg").GetComponent<Image>().color = so.GetColor().GetColorBySolitaireColor();

        Transform t = trs.Find("bg").Find("Text");

        TextMeshProUGUI tm = t.GetComponent<TextMeshProUGUI>();

        tm.text = "" + (int)so.GetLevel();
    }



    public void CreateViewOnRoot(GameObject go, float destroyDelay = -1, UICreateRoot root = UICreateRoot.Default)
    {
        go.transform.SetParent(transform.GetChild((int)root));

        go.transform.localPosition = Vector2.zero;
    }
}
