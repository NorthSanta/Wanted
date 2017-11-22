using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementrotation : MonoBehaviour {
    public MyVec move;
    public float x, y, z;
    MyVec angularV;
    public MyQuat init;
    MyQuat final;
    MyQuat rot;
    MyVec angularD;

    MyVec drag = new MyVec(0,0,0);
    MyVec gravity = new MyVec(0,0,0);
    MyVec magnuss = new MyVec(0, 0, 0);


    
    [SerializeField]
    private float proportionalCoef;
    [SerializeField]
    private float magnussCoef;
    [SerializeField]
    private float airDens;
    [SerializeField]
    private float radius;
    [SerializeField]
    private float crossSectionalArea;

    struct perdigo
    {
        public MyVec pos;
        public MyVec vel;
        public MyVec angularV;
        public MyVec forces;
        public MyQuat rotation;
    }

    perdigo perd = new perdigo();
    // Use this for initialization
    void Start () {


        perd.pos = new MyVec(transform.position.x, transform.position.y, transform.position.z);
        perd.vel = new MyVec(0, 0, 300f);
        perd.angularV = new MyVec(0, 4f, 0);
        perd.forces = drag + gravity + magnuss;
        move = new MyVec(transform.position.x, transform.position.y, transform.position.z);
        init = new MyQuat(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        
      

    }
	
	// Update is called once per frame
	void Update () {




        

        

       
        angularV = new MyVec(x, y, z);
        angularD = perd.angularV * Time.deltaTime;
        perd.angularV.normalize();
        rot = new MyQuat(perd.angularV.x, perd.angularV.y, perd.angularV.z, angularD.length());
        //Debug.DrawLine(transform.position, new Vector3(angularV.x, angularV.y, angularV.z) + transform.position, Color.blue);
        final = rot *new MyQuat(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        transform.rotation = new Quaternion(final.x, final.y, final.z, final.w);
    }
}
