﻿using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	//Inherit from Enemy.cs so that we can use the enemy script's public bool isDestroyed.  

	//This object spawns another enemy every time one is destroyed


	//Actually,
	//This object spawns the next premade wave of enemies everytime the previous wave
	//is destroyed.  
	//This should work like the lasershoot script.  

	//We also need to make an array of different waypoints possible.  
	//Every time any of the enemies is spawned, it is given one of the waypoints.  



	//public Transform projectile2;
	
	//_________VERSION 2_____________




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
	private int iNextLightEnem = 0;
	private float fMagLightEnem = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime2 = 0.0f;
	private float spawnNextDelay2 = 0.08f;

	//Enemy 3
	public GameObject goMediumEnemPrefab;//MediumPlane Enemy
	private GameObject[] argoMediumEnems = new GameObject[300];
	private int iNextMediumEnem = 0;
	private float fMagMediumEnem = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime3 = 0.0f;
	private float spawnNextDelay3 = 0.08f;

	//Enemy 4
	public GameObject goHeavyEnemPrefab;//HeavyPlane Enemy
	private GameObject[] argoHeavyEnems = new GameObject[300];
	private int iNextHeavyEnem = 0;
	private float fMagHeavyEnem = 600.0f;//1 Frame = 1000.  So bulletspeed = playerSpeed * 1000 to keep up
	private float spawnNextTime4 = 0.0f;
	private float spawnNextDelay4 = 0.08f;

	
	//private GameObject temp;

	private int levelAndWaveMarker = 1;//Starts at 1

	//Level 1 has 3 waves
	private int lvl1wave1Mark = 1;
	private int lvl1wave2Mark = 2;
	private int lvl1wave3Mark = 3;

	private int lvl1wave1Amount = 5;//5 scout planes
	//private int numScoutsInlvl1wave1 = 5;
	//private int numLightEnemsInlvl1wave1 = 0;
	//private int numMediumEnemsInlvl1wave1 = 0;
	//private int numHeavyEnemsInlvl1wave1 = 0;
	private int lvl1wave2Amount = 2;//2 medium planes
	private int lvl1wave3Amount = 1;//1 heavy plane

	private int numEnemiesLeftInlvl1wave1Amount;//decrement when one of the planes is destroyed
	private int numEnemiesLeftInlvl1wave2Amount;
	private int numEnemiesLeftInlvl1wave3Amount;



	//Level 2 has 3 waves
	private int lvl2wave1Mark = 4;
	private int lvl2wave2Mark = 5;
	private int lvl2wave3Mark = 6;


	private int lvl2wave1Amount = 10;//10 light planes
	private int lvl2wave2Amount = 10;// 7 scout planes, and 3 medium planes
	private int lvl2wave3Amount = 15;// 2 heavy planes, 6 light planes, and 7 scout planes

	private int numEnemiesLeftInlvl2wave1Amount;
	private int numEnemiesLeftInlvl2wave2Amount;
	private int numEnemiesLeftInlvl2wave3Amount;



	//Level 3 has 4 waves


	private int lvl3wave1Mark = 7;
	private int lvl3wave2Mark = 8;
	private int lvl3wave3Mark = 9;
	private int lvl3wave4Mark = 10;
	
	
	private int lvl3wave1Amount = 5;//5 medium planes
	private int lvl3wave2Amount = 10;// 10 Medium Planes
	private int lvl3wave3Amount = 3;// 3 Heavy Planes
	private int lvl3Wave4Amount = 20;//20 Medium Planes
	
	private int numEnemiesLeftInlvl3wave1Amount;
	private int numEnemiesLeftInlvl3wave2Amount;
	private int numEnemiesLeftInlvl3wave3Amount;
	private int numEnemiesLeftInlvl3wave4Amount;




	//Level 4 has 5 waves


	private int lvl4wave1Mark = 11;
	private int lvl4wave2Mark = 12;
	private int lvl4wave3Mark = 13;
	private int lvl4wave4Mark = 14;
	private int lvl4wave5Mark = 15;
	
	
	private int lvl4wave1Amount = 5;//5 Heavy Planes
	private int lvl4wave2Amount = 8;// 7 Medium Planes, 1 Heavy Plane
	private int lvl4wave3Amount = 15;// 10 scout planes, 5 Light Planes
	private int lvl4Wave4Amount = 30;//30 Light Planes
	private int lvl4Wave5Amount = 10;//10 Heavy Planes//Was originally 15 medium planes, 5 Heavy Planes
	
	private int numEnemiesLeftInlvl4wave1Amount;
	private int numEnemiesLeftInlvl4wave2Amount;
	private int numEnemiesLeftInlvl4wave3Amount;
	private int numEnemiesLeftInlvl4wave4Amount;
	private int numEnemiesLeftInlvl4wave5Amount;




	private bool enemiesOfCurrentWaveHaveBeenSpawned;





	private bool waveDestroyed; //turns on and off
	private Vector3 spawnLocation1;//changes each wave.  Use for any 1 type of enemy
	private Vector3 spawnLocation2;//changes each wave.  Use for any 1 type of enemy
	private Vector3 spawnLocation3;//changes each wave.  Use for any 1 type of enemy
	private Vector3 spawnLocation4;//changes each wave.  Use for any 1 type of enemy

	//Spawn function:  Instantiate(GameObject object, x, y, z);  <----That's all!!!!



	/*
	private int yieldTimeMin = 2;
	private int yieldTimeMax = 5;

	static int enemyCounter = 0;

	private int spawnXOffsetMin = 0;
	private int spawnXOffsetMax = 0;

	private int spawnYOffsetMin = 0;
	private int spawnYOffsetMax = 0; 

	private int spawnZOffsetMin = 0;
	private int spawnZOffsetMax = 0;

	private int defaultSpawnNumber = 5;//

	private int waveNumber = 1;
	*/





	// Use this for initialization
	void Start () 
	{
		//Don't know if we need Code from 'Outline' to 'Enemy 4'.  Actually, we need this because
		//We pre-spawn all of the objects without the x,y,z position argument in the game.  
		//The x,y, and z addition for each instatiate call shown below will be called when the
		//object has been accessed.  




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




		//Randomize _WaypointStartScripti Somewhere in here.  Put anywhere!//Ignore this for now  



		numEnemiesLeftInlvl1wave1Amount = 5;//decrement when one of the planes is destroyed in this wave
		numEnemiesLeftInlvl1wave2Amount = 2;
		numEnemiesLeftInlvl1wave3Amount = 1;

		numEnemiesLeftInlvl2wave1Amount = 10;
		numEnemiesLeftInlvl2wave2Amount = 10;
		numEnemiesLeftInlvl2wave3Amount = 15;

		numEnemiesLeftInlvl3wave1Amount = 5;
		numEnemiesLeftInlvl3wave2Amount = 10;
		numEnemiesLeftInlvl3wave3Amount = 3;
		numEnemiesLeftInlvl3wave4Amount = 20;

		numEnemiesLeftInlvl4wave1Amount = 5;
		numEnemiesLeftInlvl4wave2Amount = 8;
		numEnemiesLeftInlvl4wave3Amount = 15;
		numEnemiesLeftInlvl4wave4Amount = 30;
		numEnemiesLeftInlvl4wave5Amount = 10;





		enemiesOfCurrentWaveHaveBeenSpawned = false;

		waveDestroyed = false;

		//levelAndWaveMarker = 1;



		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//Randomize _WaypointUpdateScripti Somewhere in here.  Put anywhere!//Ignore this for now  
		

		//if (Input.GetKey(KeyCode.Space)) //Just hold down to shoot
		//{

			

		//}
		
		//Destroy(temp);


		//_____Spawn Code here______________



		//for(int i = 0; i < maxWaveCount; i++

		//While the wave is not destoryed
		//if(waveDestroyed == false)
		//{





		//	if(true)
		//	{
		//		waveDestroyed = true;
		//	}
		//}







		//if(waveDestroyed == true)
		//{
		//	levelAndWaveMarker++;
		//	waveDestroyed = false;
		//}

	//switch(levelAndWaveMarker)
	//{
	//case 1://Level 1 wave 1
		if(levelAndWaveMarker == 1)
		{
				/*
				private int lvl1wave1Mark = 1;
				private int lvl1wave2Mark = 2;
				private int lvl1wave3Mark = 3;
				
				private int lvl1wave1Amount = 5;//5 scout planes
				//private int numScoutsInlvl1wave1 = 5;
				//private int numLightEnemsInlvl1wave1 = 0;
				//private int numMediumEnemsInlvl1wave1 = 0;
				//private int numHeavyEnemsInlvl1wave1 = 0;
				private int lvl1wave2Amount = 2;//2 medium planes
				private int lvl1wave3Amount = 1;//1 heavy plane
				
				private int numEnemiesLeftInlvl1wave1Amount;//decrement when one of the planes is destroyed
				private int numEnemiesLeftInlvl1wave2Amount;
				private int numEnemiesLeftInlvl1wave3Amount;
				*/


				//for(int i = 0; i < lvl1wave1Amount; i++)
				//{
				//}

			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
					//Necessary since we are in the update function that's called in a loop.  
			{
					//Spawn enemies of this specific wave here
				SpawnScout ();
				//PlayerView.numOfEnemiesLeft = PlayerView.numOfEnemiesLeft + 1;
				SpawnScout ();
				//PlayerView.numOfEnemiesLeft++;
				SpawnScout ();
				//PlayerView.numOfEnemiesLeft++;
				SpawnScout ();
				//PlayerView.numOfEnemiesLeft++;
				SpawnScout ();
				//PlayerView.numOfEnemiesLeft++;
				//PlayerView.numOfEnemiesLeft = 5;
			

				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}



			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{


				if(PlayerView.numOfEnemiesLeft <= 0)
				{
				//levelAndWaveMarker++;//This will keep incrementing.  
				
				//Move to next wave.
					levelAndWaveMarker = 2;  //Stay at the argument of this switch statement as shown on RHS

					Debug.Log ("LevelAndWaveMarker is " + levelAndWaveMarker);

					enemiesOfCurrentWaveHaveBeenSpawned = false;

					PlayerView.numOfEnemiesLeft = 0;
				}

			}


		//break;

		}


			//case 2://Level 1 wave 2
		if(levelAndWaveMarker == 2)
		{
		
			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
			//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();

				//PlayerView.numOfEnemiesLeft = 2;

				enemiesOfCurrentWaveHaveBeenSpawned = true;
				Debug.Log ("enemies now " + PlayerView.numOfEnemiesLeft);
			}
				

				
				
				
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
				//levelAndWaveMarker++;//This will keep incrementing.  
							
				//Move to next wave.
					levelAndWaveMarker = 3;  //Stay at the argument of this switch statement as shown on RHS
						
					enemiesOfCurrentWaveHaveBeenSpawned = false;

					PlayerView.numOfEnemiesLeft = 0;

				}
			}
					

				



				//break;

		}


			//case 3://Level 1 wave 3
		if(levelAndWaveMarker == 3)
		{

			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				SpawnHeavyEnemy ();
				//PlayerView.numOfEnemiesLeft = 1;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 4;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;

					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}
			
			

				
				
					//break;
		}


			//case 4://Level 2 wave 1
		if(levelAndWaveMarker == 4)
		{

			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();

				//PlayerView.numOfEnemiesLeft = 10;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 5;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}

			//break;
		}


			//case 5://Level 2 wave 2
		if(levelAndWaveMarker == 5)
		{
			// 7 scout planes, and 3 medium planes
			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				SpawnScout ();
				SpawnScout ();
				SpawnScout ();
				SpawnScout ();
				SpawnScout ();
				SpawnScout ();
				SpawnScout ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				
				PlayerView.numOfEnemiesLeft = 10;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 6;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}


			//break;
		}


			//case 6://Level 2 wave 3
		if(levelAndWaveMarker == 6)
		{
			// 2 heavy planes, 6 light planes, and 7 scout planes

			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				SpawnHeavyEnemy ();
				SpawnHeavyEnemy ();
				SpawnLightEnemy ();
				SpawnLightEnemy ();
				SpawnLightEnemy ();
				SpawnLightEnemy ();
				SpawnLightEnemy ();
				SpawnLightEnemy ();
				SpawnScout ();
				SpawnScout ();
				SpawnScout ();
				SpawnScout ();
				SpawnScout ();
				SpawnScout ();
				SpawnScout ();
				
				PlayerView.numOfEnemiesLeft = 15;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 7;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}



			//break;
		}


			//case 7://Level 3 wave 1
		if(levelAndWaveMarker == 7)
		{
			//5 medium planes

			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				
				PlayerView.numOfEnemiesLeft = 5;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 8;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}

			//break;
		}


			//case 8://Level 3 wave 2
		if(levelAndWaveMarker == 8)
		{
			// 10 Medium Planes

			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				
				PlayerView.numOfEnemiesLeft = 10;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{


				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 9;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}
			//break;
		}


			//case 9://Level 3 wave 3
		if(levelAndWaveMarker == 9)
		{
			//3 Heavy Planes

			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				SpawnHeavyEnemy ();
				SpawnHeavyEnemy ();
				SpawnHeavyEnemy ();
				
				PlayerView.numOfEnemiesLeft = 3;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				
				
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 10;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}	
			//break;
		}


			//case 10://Level 3 wave 4
		if(levelAndWaveMarker == 10)
		{
			//20 Medium Planes

			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();

				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				
				PlayerView.numOfEnemiesLeft = 20;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				
				
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 11;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}	

			//break;
		}


			//case 11://Level 4 wave 1
		if(levelAndWaveMarker == 11)
		{
			/*private int lvl4wave1Amount = 5;//5 Heavy Planes
	private int lvl4wave2Amount = 8;// 7 Medium Planes, 1 Heavy Plane
	private int lvl4wave3Amount = 15;// 10 scout planes, 5 Light Planes
	private int lvl4Wave4Amount = 30;//30 Light Planes
	private int lvl4Wave5Amount = 10;//10 Heavy Planes//Was originally 15 medium planes, 5 Heavy Planes*/

			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here

				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				
				PlayerView.numOfEnemiesLeft = 5;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				
				
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 12;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}	


			//break;
		}


			//case 12://Level 4 wave 2
		if(levelAndWaveMarker == 12)
		{
			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				//Spawn enemies of this specific wave here
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnMediumEnemy ();
				SpawnHeavyEnemy();
				
				PlayerView.numOfEnemiesLeft = 8;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				
				
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 13;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}	
			//break;
		}


			//case 13://Level 4 wave 3
		if(levelAndWaveMarker == 13)
		{
			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here

				
				SpawnScout();
				SpawnScout();
				SpawnScout();
				SpawnScout();
				SpawnScout();
				SpawnScout();
				SpawnScout();
				SpawnScout();
				SpawnScout();
				SpawnScout();
				
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				
				PlayerView.numOfEnemiesLeft = 15;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				
				
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 14;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}	
			//break;
		}


			//case 14://Level 4 wave 4
		if(levelAndWaveMarker == 14)
		{
			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				
				
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				SpawnLightEnemy();
				
				PlayerView.numOfEnemiesLeft = 30;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				
				
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 15;  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}	
			//break;
		}


			//case 15://Level 4 wave 5
		if(levelAndWaveMarker == 15)
		{
			if(enemiesOfCurrentWaveHaveBeenSpawned == false)//Spawn wave only if wave wasn't spawned yet
				//Necessary since we are in the update function that's called in a loop.  
			{
				//Spawn enemies of this specific wave here
				
				
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				SpawnHeavyEnemy();
				
				PlayerView.numOfEnemiesLeft = 10;
				
				enemiesOfCurrentWaveHaveBeenSpawned = true;
			}
			
			
			
			
			
			//if(numEnemiesLeftInlvl1wave1Amount == 0)
			//yield return new WaitForSeconds (2);
			if(Time.time > 2.0f)
			{
				
				
				//if(numEnemiesLeftInlvl1wave2Amount == 0)
				if(PlayerView.numOfEnemiesLeft <= 0)
				{
					//levelAndWaveMarker++;//This will keep incrementing.  
					
					//Move to next wave.
					levelAndWaveMarker = 15;//Last level. Loop back to level 4 wave 5 for now  //Stay at the argument of this switch statement as shown on RHS
					
					enemiesOfCurrentWaveHaveBeenSpawned = false;
					
					PlayerView.numOfEnemiesLeft = 0;
					
				}
			}	
			//break;
		}



		//}


		
	}



	//_Spawn Functions:  




	//Don't know if we will need these: //Actually we do.  This is the code that accesses from 
	//the list of already instantiated enemies.  We don't want to say Instantiate(...) every time.  
	//We want to just 



	void SpawnScout (float x = 0.0f, float y = 0.0f, float z = 0.0f) 
	{
		PlayerView.numOfEnemiesLeft++;
		//Use SpawnObject outline

		GameObject go = argoScouts[iNextScout++];
		
		if (iNextScout >= argoScouts.Length) iNextScout = 0;
		
		//Fire the projectile
		go.SetActive (true);

		//Offset the scout by a little every time the one before spawned.  
		//go.transform.position = 
		go.transform.TransformPoint(x, y, z);

		//Object's waypoint goes here.  Replace this with something else, or not use this at all
		//if the waypoints are already inside each object.  
		//Chase AI code will replace waypoint code at same area: 

	}


	void SpawnLightEnemy (float x = 0.0f, float y = 0.0f, float z = 0.0f) 
	{
		PlayerView.numOfEnemiesLeft++;
		//Use SpawnObject outline

		GameObject go = argoLightEnems[iNextLightEnem++];
		
		if (iNextLightEnem >= argoLightEnems.Length) iNextLightEnem = 0;
		
		//Fire the projectile
		go.SetActive (true);


		go.transform.TransformPoint (x,y,z);



	}



	void SpawnMediumEnemy (float x = 0.0f, float y = 0.0f, float z = 0.0f) 
	{
		PlayerView.numOfEnemiesLeft++;
		//Use SpawnObject outline

		GameObject go = argoMediumEnems[iNextMediumEnem++];
		
		if (iNextMediumEnem >= argoMediumEnems.Length) iNextMediumEnem = 0;
		
		//Fire the projectile
		go.SetActive (true);

		go.transform.TransformPoint (x, y, z);


	}





	void SpawnHeavyEnemy (float x = 0.0f, float y = 0.0f, float z = 0.0f) 
	{
		PlayerView.numOfEnemiesLeft++;
		//Use SpawnObject outline

		GameObject go = argoHeavyEnems[iNextHeavyEnem++];
		
		if (iNextHeavyEnem >= argoHeavyEnems.Length) iNextHeavyEnem = 0;
		
		//Fire the projectile
		go.SetActive (true);


		go.transform.TransformPoint(x, y, z);


	}







}
