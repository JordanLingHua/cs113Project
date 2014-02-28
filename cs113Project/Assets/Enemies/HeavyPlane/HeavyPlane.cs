﻿using UnityEngine;
using System.Collections;

public class HeavyPlane : Enemy {

	//Speeds
	//public float rotateSpeed;
	//private const float speed = 60.0f;
	
	//Enemy armor
	//private int armor;
	
	// Use this for initialization
	void Start () {
		base.startInit();

		armor = 100;

		score = 350;
		
		speed = 30.0f;
		rotateSpeed = Random.Range(50,70);
		
		setPath(PATH_CIRCLE);
	}
}
