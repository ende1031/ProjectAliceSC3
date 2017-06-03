using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {

    int color; //0:노, 1:빨, 2:파, 3:주, 4:초, 5:보

    float crop;

	void Start () {
        crop = 1.0f;
	}
	
	void Update () {

        crop -= 0.5f * Time.deltaTime;
        if (crop <= 0)
            crop = 1.0f;
        GetComponent<Image>().fillAmount = crop;
	}
}
