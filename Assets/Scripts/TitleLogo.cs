using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleLogo : MonoBehaviour {

    Vector3 scale;
    float tempScale;
    float speed;
    float aSpeed;
    bool down;

    float alpha;
    Color tempColor;

    void Start () {
        tempColor = GetComponent<Image>().color;
        alpha = 0;

        scale = GetComponent<RectTransform>().localScale;
        tempScale = 0;
        speed = 1.2f;
        aSpeed = 1.09f;

        down = true;
    }
	
	void Update () {

        if (down)
        {
            if (tempScale < scale.x + 0.1f)
            {
                tempScale += speed * Time.deltaTime;
                speed *= aSpeed;
                if (tempScale >= scale.x + 0.1f)
                {
                    speed = 2.0f;
                    down = false;
                }
            }
        }
        else
        {
            tempScale -= speed * Time.deltaTime;
            speed /= aSpeed;
            if (tempScale <= scale.x)
            {
                tempScale = scale.x;
            }
        }

        if(alpha < 1.0f)
        {
            alpha += 1.5f * Time.deltaTime;
            if (alpha >= 1.0f)
                alpha = 1.0f;
        }

        tempColor.a = alpha;
        GetComponent<Image>().color = tempColor;

        GetComponent<RectTransform>().localScale = new Vector3(tempScale, tempScale, tempScale);
    }
}
