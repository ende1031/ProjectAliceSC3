using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour {

    public float MoveSpeed;
    public GameObject BG2;
    public float Width;

    Vector3 temp;
    
    void Start () {
        temp = transform.position;
        temp.x = Width / 2 - 9.6f / 2;
        transform.position = temp;
    }
	
	void Update () {
        transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);

        if(BG2.transform.position.x <= Width / 2 - 9.6f / 2)
        {
            temp = BG2.transform.position;
            transform.position = temp;
        }
    }
}
