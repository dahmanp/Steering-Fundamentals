using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : Kinematic
{
    Wander myMoveType;

    void Start()
    {
        myMoveType = new Wander();
        myMoveType.character = this;
        //myMoveType.target = myTarget;
    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myMoveType.getSteering().angular;
        base.Update();
    }
}