using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CustomPhysics:MonoBehaviour
{
    public static Vector gravity;
    public static Vector velocity;
    public static Vector circleVelocity;
    public static Vector force;
    public static Vector acceleration;
    public static Vector circleAcceleration;
    public static float Radius;
    public static float mass;
    [NonSerialized] public Transform objectTransform;

    private void Start()
    {
        objectTransform = GetComponent<Transform>();
    }
 //   private void Update()
 //   {
 //       LinearVelocity();
 //   }
    public void CircleVelocity()
    {
        circleVelocity = new Vector(objectTransform.position.x, objectTransform.position.y, objectTransform.position.z);
    }

    public void CircleAcceleration() //a=(v^2)/r   linear velocity
    {
        //circleAcceleration = circleVelocity * circleVelocity / Radius;
    }

    public void LinearAcceleration() 
    {
        
    }

    public void LinearVelocity() 
    {
        velocity = new Vector(objectTransform.position.x, objectTransform.position.y, objectTransform.position.z);
        Debug.Log("Velocity: " + velocity.X+ " "+velocity.Y+" "+ velocity.Z+ " "+velocity.Angle);
    }
}
