using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 v = Input.mousePosition;
        v.z = 0.8f;
        v = Camera.main.ScreenToWorldPoint(v);
        transform.position = v;
        //MyVec v =new MyVec( Input.mousePosition.x, Input.mousePosition.y, -9.15f);
    }
}
