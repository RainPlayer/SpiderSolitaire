using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Card:MonoBehaviour
{
    public void InitData(Solitaire so)
    {
        transform.Find("bg").GetComponent<Image>().color = so.GetColor().GetColorBySolitaireColor();

        Transform t = transform.Find("bg").Find("Text");

        TextMeshProUGUI tm = t.GetComponent<TextMeshProUGUI>();

        tm.text = "" + (int)so.GetLevel();
    }
}
