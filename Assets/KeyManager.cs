using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour {
    public bool rClicked;
    public bool gClicked;
    public bool bClicked;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            rClicked = !rClicked;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            gClicked = !gClicked;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            bClicked = !bClicked;
        }
    }
}
