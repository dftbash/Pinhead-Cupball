﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperscript : MonoBehaviour {
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;
    public string inputName;

	// Use this for initialization
	void Start ()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

		if(Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
	}
}
