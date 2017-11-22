using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVec
{
    public float x, y, z;
    public MyVec normalized;
    public MyVec()
    {
        this.x = 0;
        this.y = 0;
        this.z = 0;
        
    }
    public MyVec(float _x, float _y, float _z)
    {
        this.x = _x;
        this.y = _y;
        this.z = _z;
       
    }
    public void normalize()
    {
        this.x = this.x / length();
        this.y = this.y / length();
        this.z = this.z / length();
        
        
    }
    public float length()
    {
        return Mathf.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z * this.z));
    }
    
    public MyVec crossProduct(MyVec v, MyVec u)
    {
        MyVec c = new MyVec();
        c.x = v.y * u.z - v.z * u.y;
        c.y = v.z * u.x - v.x * u.z;
        c.z = v.x * u.y - v.y * u.x;          
                        
        return c;
    }
    public float dotProduct(MyVec v, MyVec u)
    {
        float a = v.x * u.x + v.y * u.y + v.z * u.z;
        return a;
    }

    public static MyVec operator *(MyVec q, float p)
    {
        MyVec m = new MyVec();
        m.x = q.x * p;
        m.y = q.y * p;
        m.z = q.z * p;
        return m;
    }

    public static MyVec operator +(MyVec q, MyVec p)
    {
        MyVec m = new MyVec();
        m.x = q.x + p.x;
        m.y = q.y + p.y;
        m.z = q.z + p.z;
        return m;
    }
}
