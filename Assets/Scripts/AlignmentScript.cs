using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignmentScript : MonoBehaviour
{
    //MyQuat
    public Transform target1;
    public Transform target2;
	public int exercise;

    public MyQuat rIni;
    public MyQuat gIni;
    MyQuat quad;
    MyQuat quad2;
    MyQuat final;
    MyQuat final2;
    MyQuat test;
    // Use this for initialization
    void Start ()
    {
        rIni = new MyQuat(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        gIni = new MyQuat(target1.rotation.x, target1.rotation.y, target1.rotation.z, target1.rotation.w);
        //Debug.Log(rIni.x);
        quad = gIni * rIni.inverse();//quad.multiply(gIni, rIni.inverse());
        // quad = gIni * new MyQuat(-rIni.x, -rIni.y, -rIni.z, rIni.w);
        quad2 = quad.inverse();
        test = new MyQuat(-0.365f, -0.663f, -0.282f, 0.590f);
        axisAngle axis = test.toAxisAngle();
        Debug.Log(axis.x);
        Debug.Log(axis.w);
        //axis.w = 
    }

    void Update()
    {
        switch(exercise)
        {
            case 1:
            {
                    float a = -Mathf.Acos(Vector3.Dot(transform.right,target1.right))*Mathf.Rad2Deg;
                    Vector3 axis = Vector3.Cross(transform.right, target1.right).normalized;
                    target1.Rotate(axis, a,Space.World);

                    float b = -Mathf.Acos(Vector3.Dot(transform.forward, target1.forward)) * Mathf.Rad2Deg;
                    axis = Vector3.Cross(transform.up, target1.up).normalized;
                    target1.Rotate(axis, b,Space.World);

                    //float c = Mathf.Acos(Vector3.Dot(transform.up, target1.up));
                    ////axis = Vector3.Cross(transform.forward, target1.forward);
                    //target1.Rotate(transform.forward, -c);

                   


                } break;

          

            case 2:
            {
                    
                } break;

            case 3:
            {
                    
                   // target1.rotation = quad * transform.rotation;
            } break;

            case 4:
            {
                    
                    final = quad * new MyQuat(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
                    //Debug.Log(final.x);
                    final2 = quad2 * new MyQuat(target1.rotation.x, target1.rotation.y, target1.rotation.z, target1.rotation.w);
                    //target1.rotation.Set(final.x, final.y, final.z, final.w);
                    target1.rotation = new Quaternion(final.x,final.y,final.z,final.w);
                    target2.rotation = new Quaternion(final2.x, final2.y, final2.z, final2.w);
                    
                } break;
        }
    }
}
