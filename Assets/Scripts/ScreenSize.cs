using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour {

    public int screenSizeX;
    public int screenSizeY;


    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep; //실행중 화면 꺼짐 방지
        Screen.SetResolution(960, 540, true);
    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}