using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalExtension 
{
    public static Color GetColorBySolitaireColor(this SolitaireColor color)
    {
        Color co = Color.white;

        switch (color)
        {
            case SolitaireColor.SolitaireColor_red:
                {
                    co = new Color(174.0f / 255, 40.0f / 255, 40.0f / 255);
                }
                break;
            case SolitaireColor.SolitaireColor_Green:
                {
                    co = new Color(60.0f / 255, 173.0f / 255, 40.0f / 255);
                }
                break;
            case SolitaireColor.SolitaireColor_Yellow:
                {
                    co = new Color(222.0f / 255, 185.0f / 255, 0.0f / 255);

                }
                break;
            case SolitaireColor.SolitaireColor_Blue:
                {
                    co = new Color(59.0f / 255, 50.0f / 255, 183.0f / 255);

                }
                break;
            default:
                break;
        }

        return co;
    }
}
