using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    Vector3 v;
    float ZPos;
    // Use this for initialization
    void Start()
    {
        ZPos = 0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.mousePosition;
        v.z = ZPos;
        if (Input.GetKey(KeyCode.W))
            ZPos += 0.05f;
        else if (Input.GetKey(KeyCode.S))
            ZPos -= 0.05f;
        v = Camera.main.ScreenToWorldPoint(v);
        transform.position = v;


        //MyVec v =new MyVec( Input.mousePosition.x, Input.mousePosition.y, -9.15f);
    }
}
