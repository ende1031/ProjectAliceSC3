using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAlpha : MonoBehaviour {

    public float AlphaSpeed;
    public float StartAlpha;
    public float MaxAlpha;
    public float MinAlpha;

    float alpha;
    Color tempColor;
    bool decreaseAlpha; //true일때 Alpa감소

    void Start () {
        tempColor = GetComponent<Image>().color;
        alpha = 0;
        decreaseAlpha = false;
    }
	
	void Update () {
        if (!decreaseAlpha) //Alpha증가
        {
            alpha += AlphaSpeed * Time.deltaTime;
            if (alpha >= MaxAlpha)
            {
                if (alpha > 1.0f)
                    alpha = MaxAlpha;
                decreaseAlpha = true;
            }
        }
        else //Alpa감소
        {
            alpha -= AlphaSpeed * Time.deltaTime;
            if (alpha <= MinAlpha)
            {
                if (alpha < 0)
                    alpha = MinAlpha;
                decreaseAlpha = false;
            }
        }
        tempColor.a = alpha;
        GetComponent<Image>().color = tempColor;
    }
}