using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : Seek
{
    float wanderOffset;
    float wanderRadius;
    float wanderRate;
    float wanderOrientation;
    float maxAcceleration;

    /*public override SteeringOutput getSteering()
    {
        wanderOrientation += (Random.value + Random.value) * wanderRate * Mathf.Rad2Deg;
        float targetOrientation = wanderOrientation + character.transform.eulerAngles.y;

        Vector3 targetPos = character.transform.position + (wanderOffset * Vector3.one) + character.transform.forward;

        targetPos += wanderRadius * targetOrientation * Vector3.one;

        result.angular = Face(targetPos).angular;

        result.linear = maxAcceleration * character.transform.forward;

        return result;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
