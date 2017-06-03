using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameAnimation : MonoBehaviour {

    public AnimatorOverrideController aniY;
    public AnimatorOverrideController aniB;
    public AnimatorOverrideController aniR;
    public AnimatorOverrideController aniO;
    public AnimatorOverrideController aniG;
    public AnimatorOverrideController aniP;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            GetComponent<Animator>().runtimeAnimatorController = aniY;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            GetComponent<Animator>().runtimeAnimatorController = aniB;
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            GetComponent<Animator>().runtimeAnimatorController = aniR;
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            GetComponent<Animator>().runtimeAnimatorController = aniO;
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            GetComponent<Animator>().runtimeAnimatorController = aniG;
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            GetComponent<Animator>().runtimeAnimatorController = aniP;
        }

    }
}
