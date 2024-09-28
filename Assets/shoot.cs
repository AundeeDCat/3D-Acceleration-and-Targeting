using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    float xVelocity, yVelocity, zVelocity;

    public float setTime;

    public GameObject target;
    public Rigidbody rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            setTime = EstimateTime();

            xVelocity = xVelocityCalc(setTime);
            yVelocity = yVelocityCalc(setTime);
            zVelocity = zVelocityCalc(setTime);

            rb.velocity = new Vector3(xVelocity, yVelocity, zVelocity);

            //Debug.Log(xVelocity + "," + yVelocity + "," + zVelocity);
        }
    }

    float xVelocityCalc(float time)
    {
        float targetX = target.transform.position.x - this.transform.position.x;

        return targetX / time;
    }


    float yVelocityCalc(float time)
    {
        float targetY = target.transform.position.y - this.transform.position.y;

        return (targetY + 0.5f * 9.8f * time * time) / time; ;
    }


    float zVelocityCalc(float time)
    {
        float targetZ = target.transform.position.z - this.transform.position.z;

        return targetZ / time;
    }

    float EstimateTime()
    {
        float targetY = target.transform.position.y - this.transform.position.y;

        return (targetY / 10) + 2f;
    }
}
