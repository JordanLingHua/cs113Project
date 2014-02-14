﻿using UnityEngine;
using System.Collections;

//Missile shoots here
//Missile heat-seeks here

public class MissileShoot : MonoBehaviour {


	public GameObject goProjectilePrefab;
	private GameObject[] argoProjectiles = new GameObject[900];
	//private int iNext = 0;
	private float fMag = 10000.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	



	//Heat-Seeking stuff
	public GameObject target1;
	private int totalNumOfSCOUTEnemies = 3;//Change this number when you add in more enemies
	private GameObject[] enemies1 = new GameObject[100];


	public GameObject target2;
	private int totalNumOfZEROSENEnemies = 3;//Change this number when you add in more enemies
	private GameObject[] enemies2 = new GameObject[100];

	public GameObject target3;
	private int totalNumOfCLASS3Enemies = 3;//Change this number when you add in more enemies
	private GameObject[] enemies3 = new GameObject[100];

	public GameObject target4;
	private int totalNumOfCLASS4Enemies = 3;//Change this number when you add in more enemies
	private GameObject[] enemies4 = new GameObject[100];


	// Use this for initialization
	void Start () {
		//goProjectilePrefab.SetActive (false);
		for (int i = 0; i < argoProjectiles.Length; i++) 
		{
			argoProjectiles[i] = (GameObject)Instantiate (goProjectilePrefab,this.gameObject.transform.position,this.gameObject.transform.rotation);//
			//argoProjectiles[i].transform.Rotate(0,0,90f);
			argoProjectiles[i].SetActive (false);//
		}





		//Make all the enemy planes in the game possible for selection

		for(int i = 1; i <= totalNumOfSCOUTEnemies; i++)//Don't use enemy size array list otherwise you cause null reference objects.  
		{
			//Use i as the prefix of the name
			enemies1[i-1] = GameObject.Find("Scout"+i);


		}





	}
	
	// Update is called once per frame
	void Update () {
	
		//float rotateAmount = 25f * Time.deltaTime;
<<<<<<< HEAD
		if (Input.GetKeyDown(KeyCode.Q) && Player.numEMPs != 0) //Just hold down to shoot
=======
		//if (Input.GetKeyDown(KeyCode.Q) && Player.numMissiles != 0) //Just hold down to shoot
		if (Input.GetKeyDown(KeyCode.Q))
>>>>>>> 2836010a1a205bc52c5e92be889ae96e20b852d1
		{		
			//GameObject go = argoProjectiles[iNext++];
			GameObject go = (GameObject)Instantiate (goProjectilePrefab,this.gameObject.transform.position,this.gameObject.transform.rotation);
			
			//if (iNext >= argoProjectiles.Length) iNext = 0;
			
			go.SetActive (true);
			go.rigidbody.velocity = Vector3.zero;
			go.transform.position = transform.position;//
			//go.transform.rotation = Quaternion.Euler(rotateAmount,0,0);
			go.transform.Rotate (90, 90, 90);
			//go.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);//
			//go.transform.LookAt (Vector3.zero);//
			//go.transform.rotation = transform.LookAt(transform.position + rigidbody.velocity);//
			//go.transform.Rotate (90,0,0);//
			go.rigidbody.AddForce (transform.forward * fMag);
<<<<<<< HEAD

			Player.healthAmount = Player.healthAmount - .125f;
			//Player.numLives = Player.numLives - 0.5;
			//Debug.Log (Player.numLives);
=======
			//Player.numMissiles = Player.numMissiles - 0.5;//Unlimited ammo for now
>>>>>>> 2836010a1a205bc52c5e92be889ae96e20b852d1
			//temp = go;







			//Heat Seeking Code:  

			//Vector3 newTarget = target.transform.position - transform.position;
			//go.rigidbody.velocity =  newTarget.normalized * 800;
			//go.transform.LookAt (target.transform.position);





			//if()
			//{
			//}

		}



		//Trying out the heatseeking outside here first.  


		for(int i = 0; i < totalNumOfSCOUTEnemies; i++)
		{

		}




	}
}
