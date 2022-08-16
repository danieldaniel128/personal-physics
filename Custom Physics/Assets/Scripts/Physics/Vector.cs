using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector 
{
    public float X;
    public float Y;
    public float Z;
    public float Angle;
    public Vector(float x,float y) 
    {
        X = x;
        Y = y;
        Z = 0;
        Angle = AngleCalculator();
    }
    public Vector(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
        Angle = AngleCalculator();
    }

    private float AngleCalculator()
    {
        float angle=0;
        if (X  > 0 && Y > 0)// + +
            angle = (180 / Mathf.PI) * Mathf.Atan2(Y, X);
        else if (X < 0 && Y < 0)//- -
            angle = 360+(180 / Mathf.PI) * Mathf.Atan2(Y,X);
        else if (X > 0 && Y < 0)//+ -
            angle = 270 + 180 - (180 / Mathf.PI) * Mathf.Atan2(X, Y);
        else if (X < 0 && Y > 0)//- +
            angle = 90-(180 / Mathf.PI) * Mathf.Atan2(X,Y);
        return angle;
    }
}
