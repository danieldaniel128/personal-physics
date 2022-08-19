using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CustomPhysics:MonoBehaviour
{
    public static Vector Gravity;
    [SerializeField] float _gravity;
    public static Vector Velocity;
    public static Vector circleVelocity;
    public static Vector force;
    public static Vector Acceleration;
    public static Vector circleAcceleration;
    public static float Radius;
    public static float mass;
    [NonSerialized] public Transform objectTransform;

    private void Start()
    {
        objectTransform = GetComponent<Transform>();
        //Gravity = new Vector(0, -1*_gravity, 0);
    }



    private void Update()
    {
        //LinearVelocity();
        Vector3 gravity = new Vector3(0, -_gravity * Time.deltaTime, 0);
        transform.position += gravity;
    }
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
        Velocity = new Vector(objectTransform.position.x, objectTransform.position.y, objectTransform.position.z);
        Debug.Log("Velocity: " + Velocity.X+ " "+Velocity.Y+" "+ Velocity.Z+ " "+Velocity.Angle);
    }
}
