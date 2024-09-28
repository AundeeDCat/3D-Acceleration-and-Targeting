using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acceleration : MonoBehaviour
{
    public GameObject targetFirst, targetSecond;
    public Rigidbody rb;

    Vector3 initialVelocityFirst = new Vector3(0, 0, 0);
    public Vector3 finalVelocityFirst = new Vector3(0, 0, 0);
    Vector3 initialVelocitySecond;
    Vector3 finalVelocitySecond = new Vector3(0, 0, 0);

    public float time = 0;
    float timer;

    public float currentAcceleration;

    void Start()
    {
        initialVelocitySecond = finalVelocityFirst;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (distanceToFirstTarget() >= 0)
        {
            rb.velocity = Vector3.Lerp(initialVelocityFirst, finalVelocityFirst, timer / time);
        }

        else
        {
            rb.velocity = Vector3.Lerp(initialVelocitySecond, finalVelocitySecond, timer / time);
        }

        displayAcceleration();
    }


    float distanceToFirstTarget()
    {
        return targetFirst.transform.position.x - this.transform.position.x;
    }
    
    float distanceToSecondTarget()
    {
        return targetSecond.transform.position.x - this.transform.position.x;
    }
    

    void displayAcceleration()
    {

        currentAcceleration = rb.velocity.x - initialVelocityFirst.x;

        Debug.Log("Current Acceleration: " + currentAcceleration);
    }
}
