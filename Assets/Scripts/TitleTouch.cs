using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleTouch : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
        /*
        if (Input.touchCount > 0)
        {
            Vector2 pos = Input.GetTouch(0).position;    // 터치한 위치

            Vector3 theTouch = new Vector3(pos.x, pos.y, 0.0f);    // 변환 안하고 바로 Vector3로 받아도 되겠지.

            Ray ray = Camera.main.ScreenPointToRay(theTouch);    // 터치한 좌표 레이로 바꾸엉

            RaycastHit hit;    // 정보 저장할 구조체 만들고

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))    // 레이저를 끝까지 쏴블자. 충돌 한넘이 있으면 return true다.
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)    // 딱 처음 터치 할때 발생한다
                {
                    // 할거 하고
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Moved)    // 터치하고 움직이믄 발생한다.
                {
                    // 또 할거 하고
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Ended)    // 터치 따악 떼면 발생한다.
                {
                    // 할거 해라.
                }
            }
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Gameobject obj = hit.collider.gameobject;
                if (hit.collider.CompareTag("내꺼태그"))
                {
                    // 할거 하라.
                }
            }
        }
        */

        int count = Input.touchCount;
        if (count == 0) return; //할 일이 없다.

        for (int i = 0; i < count; i++)
        {
            Touch touch = Input.GetTouch(i);
            //Debug.Log("id:" + touch.fingerId + ",phase:" + touch.phase);

            if (Input.GetTouch(i).phase == TouchPhase.Began)
                SceneManager.LoadScene("SelectStage");

        }
    }
}
