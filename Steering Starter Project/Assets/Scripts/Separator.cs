using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Separator : Kinematic
{
    Separation myMoveType;
    Align myRotateType;

    void Start()
    {
        myMoveType = new Separation();
        myMoveType.character = this;
        Kinematic[] kinematics = GameObject.FindObjectsOfType<Kinematic>();
        List<Kinematic> kinematicList = new List<Kinematic>(kinematics);
        kinematicList.Remove(this);
        myMoveType.targets = kinematicList.ToArray();

        myRotateType = new Align();
        myRotateType.character = this;
        myRotateType.target = myTarget;
    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
