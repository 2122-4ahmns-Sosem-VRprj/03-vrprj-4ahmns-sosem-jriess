using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    Rigidbody rbChicken;
    public float moveSpeed;
    bool moving;
    public LayerMask wall;
    public Transform circleTransform;
    public float circleRadius;

    private void Start()
    {
        rbChicken = GetComponent<Rigidbody>();
        Turn();
        moving = true;
    }

    private void FixedUpdate()
    {
        if (moving)
        {
            Move();
        }
    }

    void Move()
    {
        var localVelocity = transform.InverseTransformDirection(rbChicken.velocity);
        localVelocity = new Vector3(0, rbChicken.velocity.y, moveSpeed);
        rbChicken.velocity = transform.TransformDirection(localVelocity);
    }

    void Stand()
    {
        moving = false;
        rbChicken.velocity = new Vector3(0, rbChicken.velocity.y, 0);
    }

    void Turn()
    {
        Vector3 direction = new Vector3(0, 180, 0);
        transform.Rotate(direction);
        /*if (Physics.OverlapSphere(circleTransform.position, circleRadius, wall) != null)
        {
            return;
        }
        else
        {
            Turn();
        } */      
    }

    void SpawnEgg()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Turn();
        }
    }

    /*private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(circleTransform.position, circleRadius);
    }*/
}
