using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Card 
{
    public UI_Card(Solitaire so,Transform parent)
    {
        ///创建出纸牌ui
        GameObject go = GameObject.Instantiate(Solitaire.GetPrefabs(),parent);

        Transform trs = go.transform;

        trs.localPosition = Vector2.zero;

        trs.localScale = Vector2.one;

        trs.Find("bg").GetComponent<Image>().color = so.GetColor().GetColorBySolitaireColor();

        Transform t = trs.Find("bg").Find("Text");

        TextMeshProUGUI tm = t.GetComponent<TextMeshProUGUI>();

        tm.text = "" + (int)so.GetLevel();
    }




    



}
