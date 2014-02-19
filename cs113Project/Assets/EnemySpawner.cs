﻿using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {


	//This object spawns another enemy every time one is destroyed

	//Actually,
	//This object spawns the next premade wave of enemies everytime the previous wave
	//is destroyed.  
	//This should work like the lasershoot script.  

	//We also need to make an array of different waypoints possible.  
	//Every time any of the enemies is spawned, it is given one of the waypoints.  
		


	//public Transform projectile2;
	
	//_________VERSION 2_____________

	//Outline:  
	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[300];
	private int iNext = 0;
	private float fMag = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float fireNextTime = 0.0f;
	private float fireNextDelay = 0.08f;


	//Enemy 1
	public GameObject goScoutPrefab;//Scout
	private GameObject[] argoScouts = new GameObject[300];
	private int iNextScout = 0;
	private float fMagScout = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime1 = 0.0f;
	private float spawnNextDelay1 = 0.08f;

	//Enemy 2
	public GameObject goLightEnemPrefab;//LightPlane Enemy
	private GameObject[] argoLightEnems = new GameObject[300];
	private int iNextLightEnems = 0;
	private float fMagLightEnem = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime2 = 0.0f;
	private float spawnNextDelay2 = 0.08f;

	//Enemy 3
	public GameObject goMediumEnemPrefab;//MediumPlane Enemy
	private GameObject[] argoMediumEnems = new GameObject[300];
	private int iNextMediumEnems = 0;
	private float fMagMediumEnem = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime3 = 0.0f;
	private float spawnNextDelay3 = 0.08f;

	//Enemy 4
	public GameObject goHeavyEnemPrefab;//HeavyPlane Enemy
	private GameObject[] argoHeavyEnems = new GameObject[300];
	private int iNextHeavyEnems = 0;
	private float fMagHeavyEnem = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime4 = 0.0f;
	private float spawnNextDelay4 = 0.08f;

	
	//private GameObject temp;
	
	
	// Use this for initialization
	void Start () 
	{

		//Outline  
		for (int i = 0; i < argoProjectiles.Length; i++) 
		{
			argoProjectiles[i] = (GameObject)Instantiate (goProjectilePrefab);
			argoProjectiles[i].SetActive (false);
		}


		//Enemy 1
		for (int i = 0; i < argoScouts.Length; i++) 
		{
			argoScouts[i] = (GameObject)Instantiate (goScoutPrefab);
			argoScouts[i].SetActive (false);
		}
		//Enemy 2
		for (int i = 0; i < argoLightEnems.Length; i++) 
		{
			argoLightEnems[i] = (GameObject)Instantiate (goLightEnemPrefab);
			argoLightEnems[i].SetActive (false);
		}
		//Enemy 3
		for (int i = 0; i < argoMediumEnems.Length; i++) 
		{
			argoMediumEnems[i] = (GameObject)Instantiate (goMediumEnemPrefab);
			argoMediumEnems[i].SetActive (false);
		}
		//Enemy 4
		for (int i = 0; i < argoHeavyEnems.Length; i++) 
		{
			argoHeavyEnems[i] = (GameObject)Instantiate (goHeavyEnemPrefab);
			argoHeavyEnems[i].SetActive (false);
		}


		
	}
	
	// Update is called once per frame
	void Update () {
		
		

		
		//if (Input.GetKeyDown(KeyCode.Space)) //Must press it every time to shoot
		if (Input.GetKey(KeyCode.Space)) //Just hold down to shoot
		{

			
			//if the delay time passed it fires
			if(fireNextTime < Time.time)
			{
				//Fire a laser
				FireLaser();
				//Adds the fireDelay to the time verifier
				fireNextTime = Time.time + fireNextDelay;
			}
			//temp = go;
		}
		
		//Destroy(temp);
		
	}


	void FireLaser () 
	{
		
		//Take the correct projectile
		GameObject go = argoProjectiles[iNext++];
		
		if (iNext >= argoProjectiles.Length) iNext = 0;
		
		//Fire the projectile
		go.SetActive (true);
		//go.rigidbody.velocity = Vector3.zero;
		go.transform.position = transform.position + transform.forward*10;
		go.transform.rotation = transform.rotation;
		go.rigidbody.velocity = transform.forward * fMag;
		//go.rigidbody.AddForce(transform.forward * fMag);
	}
}
