using UnityEngine;
using System.Collections;

public class CutSceneTrigger : MonoBehaviour {
	
	//private GameObject player;
	//private int level;
	
	public bool allowPause;
	public bool allowPause2;
	public bool allowPause3;
	
	
	//Ichikos
	public Texture ichiko;
	public Texture ichikohair2;
	public Texture ichikoHandsBack;
	public Texture ichikoSmile;
	public Texture ichikoCloseEye;
	public Texture ichikoNewDress;
	public Texture ichikoNewDressver2;
	public Texture ichikoNewDressCloseEye;
	public Texture ichikoNewDressCloseEyever2;
	public Texture ichikoNewDressSmileCloseEyeNightver2;
	public Texture ichikoNormalHandsBackSmileCloseEye;
	
	
	//Sketches
	public Texture sketch1;
	public Texture sketch2;
	public Texture sketch3;//sketch 17 winter
	public Texture sketch3ver2; //sketch 17 winter version 2
	public Texture sketch4spring;
	public Texture sketch4summer;
	public Texture sketch4winter;
	public Texture sketch5spring;
	public Texture sketch5summer;
	public Texture sketch5winter;
	public Texture sketch6spring;
	public Texture sketch6summer;
	public Texture sketch6winter;
	public Texture sketch7yr1944winter;
	public Texture sketch7yr1944;
	public Texture sketch7yr2242;
	public Texture sketch7yr2242ver2;
	public Texture sketch7yr2242ver3;
	public Texture sketch10;
	public Texture sketch11;
	public Texture sketch13;
	public Texture sketch13ver2;
	public Texture sketch14;
	public Texture sketch15;
	public Texture sketch15ver2;
	public Texture sketch16;
	public Texture sketch16ver2;
	public Texture sketch17;//sketch 17 summer
	public Texture sketch17ver2;
	public Texture sketch18;
	public Texture sketch18ver2;
	public Texture sketch18ver3;
	public Texture sketch18ver4;
	public Texture sketch19;
	public Texture sketch19ver2;
	public Texture sketch20;
	public Texture sketch20night;
	public Texture sketch20ver2;
	public Texture sketch21;
	
	//Subtitles
	public Texture c1;
	public Texture c2;
	public Texture c3;
	public Texture c4;
	public Texture c5;
	public Texture c6;
	public Texture c7;
	public Texture c8;
	public Texture c9;
	public Texture c10;
	public Texture c11;
	public Texture c12;
	public Texture c13;
	public Texture c14;
	public Texture c15;
	public Texture c16;
	public Texture c17;
	public Texture c18;
	public Texture c19;
	public Texture c20;
	public Texture c21;
	public Texture c22;
	public Texture c23;
	public Texture c24;
	public Texture c25;
	public Texture c26;
	public Texture c27;
	public Texture c28;
	public Texture c29;
	public Texture c30;
	public Texture c31;
	public Texture c32;
	public Texture c33;
	public Texture c34;
	public Texture c35;
	public Texture c36;
	public Texture c37;
	public Texture c38;
	public Texture c39;
	public Texture c40;
	public Texture c41;
	public Texture c42;
	public Texture c43;
	public Texture c44;
	public Texture c45;
	public Texture c46;
	public Texture c47;
	public Texture c48;
	public Texture c49;
	public Texture c50;
	public Texture c51;
	public Texture c52;
	public Texture c53;
	public Texture c54;
	public Texture c55;
	public Texture c56;
	public Texture c57;
	public Texture c58;
	public Texture c59;
	public Texture c60;
	public Texture c61;
	public Texture c62;
	public Texture c63;
	public Texture c64;
	public Texture c65;
	public Texture c66;
	public Texture c67;
	public Texture c68;
	public Texture c69;
	public Texture c70;
	public Texture c71;
	public Texture c72;
	public Texture c73;
	public Texture c74;
	public Texture c75;
	public Texture c76;
	public Texture c77;
	public Texture c78;
	public Texture c79;
	public Texture c80;
	public Texture c81;
	public Texture c82;
	public Texture c83;
	public Texture c84;
	public Texture c85;
	public Texture c86;
	public Texture c87;
	public Texture c88;
	public Texture c89;
	public Texture c90;
	public Texture c91;
	public Texture c92;
	public Texture c93;
	public Texture c94;
	public Texture c95;
	public Texture c96;
	public Texture c97;
	public Texture c98;
	public Texture c99;
	public Texture c100;
	public Texture c101;
	public Texture c102;
	public Texture c103;
	public Texture c104;
	public Texture c105;
	public Texture c106;
	public Texture c107;
	public Texture c108;
	public Texture c109;
	public Texture c110;
	public Texture c111;
	public Texture c112;
	public Texture c113;
	public Texture c114;
	public Texture c115;
	public Texture c116;
	public Texture c117;
	public Texture c118;
	public Texture c119;
	public Texture c120;
	public Texture c121;
	public Texture c122;
	public Texture c123;
	public Texture c124;
	public Texture c125;
	public Texture c126;
	public Texture c127;
	public Texture c128;
	public Texture c129;
	public Texture c130;
	public Texture c131;
	public Texture c132;
	public Texture c133;
	public Texture c134;
	public Texture c135;
	public Texture c136;
	public Texture c137;
	public Texture c138;
	public Texture c139;
	public Texture c140;
	public Texture c141;
	public Texture c142;
	public Texture c143;
	public Texture c144;
	public Texture c145;
	public Texture c146;
	public Texture c147;
	public Texture c148;
	public Texture c149;
	public Texture c150;
	public Texture c151;
	public Texture c152;
	public Texture c153;
	public Texture c154;
	public Texture c155;
	public Texture c156;
	public Texture c157;
	public Texture c158;
	public Texture c159;
	public Texture c160;
	public Texture c161;
	public Texture c162;
	public Texture c163;
	public Texture c164;
	public Texture c165;
	public Texture c166;
	public Texture c167;
	public Texture c168;
	public Texture c169;
	public Texture c170;
	public Texture c171;
	public Texture c172;
	public Texture c173;
	public Texture c174;
	public Texture c175;
	public Texture c176;
	public Texture c177;
	public Texture c178;
	public Texture c179;
	public Texture c180;
	public Texture c181;
	public Texture c182;
	public Texture c183;
	public Texture c184;
	public Texture c185;
	public Texture c186;
	public Texture c187;
	public Texture c188;
	public Texture c189;
	public Texture c190;
	public Texture c191;
	public Texture c192;
	public Texture c193;
	
	
	//public Camera firstPersonCamera;
	//public Camera thirdPersonCamera;
	
	
	public bool inichiko = false;
	public bool inichikohair2 = false;
	public bool inichikoHandsBack = false;
	public bool inichikoSmile = false;
	public bool inichikoCloseEye = false;
	public bool inichikoNewDress = false;
	public bool inichikoNewDressver2 = false;
	public bool inichikoNewDressCloseEye = false;
	public bool inichikoNewDressCloseEyever2 = false;
	public bool inichikoNewDressSmileCloseEyeNightver2 = false;
	public bool inichikoNormalHandsBackSmileCloseEye = false;
	
	
	
	
	public bool insketch1 = false;
	public bool insketch2 = false;
	public bool insketch3 = false;//sketch 17 winter
	public bool insketch3ver2 = false; //sketch 17 winter version 2
	public bool insketch4spring = false;
	public bool insketch4summer = false;
	public bool insketch4winter = false;
	public bool insketch5spring = false;
	public bool insketch5summer = false;
	public bool insketch5winter = false;
	public bool insketch6spring = false;
	public bool insketch6summer = false;
	public bool insketch6winter = false;
	public bool insketch7yr1944winter = false;
	public bool insketch7yr1944 = false;
	public bool insketch7yr2242 = false;
	public bool insketch7yr2242ver2 = false;
	public bool insketch7yr2242ver3 = false;
	public bool insketch10 = false;
	public bool insketch11 = false;
	public bool insketch13 = false;
	public bool insketch13ver2 = false;
	public bool insketch14 = false;
	public bool insketch15 = false;
	public bool insketch15ver2 = false;
	public bool insketch16 = false;
	public bool insketch16ver2 = false;
	public bool insketch17 = false;//sketch 17 summer
	public bool insketch17ver2 = false;
	public bool insketch18 = false;
	public bool insketch18ver2 = false;
	public bool insketch18ver3 = false;
	public bool insketch18ver4 = false;
	public bool insketch19 = false;
	public bool insketch19ver2 = false;
	public bool insketch20 = false;
	public bool insketch20night = false;
	public bool insketch20ver2 = false;
	public bool insketch21 = false;
	
	
	
	
	
	
	public bool inc1 = false;
	public bool inc2 = false;
	public bool inc3 = false;
	public bool inc4 = false;
	public bool inc5 = false;
	public bool inc6 = false;
	public bool inc7 = false;
	public bool inc8 = false;
	public bool inc9 = false;
	public bool inc10 = false;
	public bool inc11 = false;
	public bool inc12 = false;
	public bool inc13 = false;
	public bool inc14 = false;
	public bool inc15 = false;
	public bool inc16 = false;
	public bool inc17 = false;
	public bool inc18 = false;
	public bool inc19 = false;
	public bool inc20 = false;
	public bool inc21 = false;
	public bool inc22 = false;
	public bool inc23 = false;
	public bool inc24 = false;
	public bool inc25 = false;
	public bool inc26 = false;
	public bool inc27 = false;
	public bool inc28 = false;
	public bool inc29 = false;
	public bool inc30 = false;
	public bool inc31 = false;
	public bool inc32 = false;
	public bool inc33 = false;
	public bool inc34 = false;
	public bool inc35 = false;
	public bool inc36 = false;
	public bool inc37 = false;
	public bool inc38 = false;
	public bool inc39 = false;
	public bool inc40 = false;
	public bool inc41 = false;
	public bool inc42 = false;
	public bool inc43 = false;
	public bool inc44 = false;
	public bool inc45 = false;
	public bool inc46 = false;
	public bool inc47 = false;
	public bool inc48 = false;
	public bool inc49 = false;
	public bool inc50 = false;
	public bool inc51 = false;
	public bool inc52 = false;
	public bool inc53 = false;
	public bool inc54 = false;
	public bool inc55 = false;
	public bool inc56 = false;
	public bool inc57 = false;
	public bool inc58 = false;
	public bool inc59 = false;
	public bool inc60 = false;
	public bool inc61 = false;
	public bool inc62 = false;
	public bool inc63 = false;
	public bool inc64 = false;
	public bool inc65 = false;
	public bool inc66 = false;
	public bool inc67 = false;
	public bool inc68 = false;
	public bool inc69 = false;
	public bool inc70 = false;
	public bool inc71 = false;
	public bool inc72 = false;
	public bool inc73 = false;
	public bool inc74 = false;
	public bool inc75 = false;
	public bool inc76 = false;
	public bool inc77 = false;
	public bool inc78 = false;
	public bool inc79 = false;
	public bool inc80 = false;
	public bool inc81 = false;
	public bool inc82 = false;
	public bool inc83 = false;
	public bool inc84 = false;
	public bool inc85 = false;
	public bool inc86 = false;
	public bool inc87 = false;
	public bool inc88 = false;
	public bool inc89 = false;
	public bool inc90 = false;
	public bool inc91 = false;
	public bool inc92 = false;
	public bool inc93 = false;
	public bool inc94 = false;
	public bool inc95 = false;
	public bool inc96 = false;
	public bool inc97 = false;
	public bool inc98 = false;
	public bool inc99 = false;
	public bool inc100 = false;
	public bool inc101 = false;
	public bool inc102 = false;
	public bool inc103 = false;
	public bool inc104 = false;
	public bool inc105 = false;
	public bool inc106 = false;
	public bool inc107 = false;
	public bool inc108 = false;
	public bool inc109 = false;
	public bool inc110 = false;
	public bool inc111 = false;
	public bool inc112 = false;
	public bool inc113 = false;
	public bool inc114 = false;
	public bool inc115 = false;
	public bool inc116 = false;
	public bool inc117 = false;
	public bool inc118 = false;
	public bool inc119 = false;
	public bool inc120 = false;
	public bool inc121 = false;
	public bool inc122 = false;
	public bool inc123 = false;
	public bool inc124 = false;
	public bool inc125 = false;
	public bool inc126 = false;
	public bool inc127 = false;
	public bool inc128 = false;
	public bool inc129 = false;
	public bool inc130 = false;
	public bool inc131 = false;
	public bool inc132 = false;
	public bool inc133 = false;
	public bool inc134 = false;
	public bool inc135 = false;
	public bool inc136 = false;
	public bool inc137 = false;
	public bool inc138 = false;
	public bool inc139 = false;
	public bool inc140 = false;
	public bool inc141 = false;
	public bool inc142 = false;
	public bool inc143 = false;
	public bool inc144 = false;
	public bool inc145 = false;
	public bool inc146 = false;
	public bool inc147 = false;
	public bool inc148 = false;
	public bool inc149 = false;
	public bool inc150 = false;
	public bool inc151 = false;
	public bool inc152 = false;
	public bool inc153 = false;
	public bool inc154 = false;
	public bool inc155 = false;
	public bool inc156 = false;
	public bool inc157 = false;
	public bool inc158 = false;
	public bool inc159 = false;
	public bool inc160 = false;
	public bool inc161 = false;
	public bool inc162 = false;
	public bool inc163 = false;
	public bool inc164 = false;
	public bool inc165 = false;
	public bool inc166 = false;
	public bool inc167 = false;
	public bool inc168 = false;
	public bool inc169 = false;
	public bool inc170 = false;
	public bool inc171 = false;
	public bool inc172 = false;
	public bool inc173 = false;
	public bool inc174 = false;
	public bool inc175 = false;
	public bool inc176 = false;
	public bool inc177 = false;
	public bool inc178 = false;
	public bool inc179 = false;
	public bool inc180 = false;
	public bool inc181 = false;
	public bool inc182 = false;
	public bool inc183 = false;
	public bool inc184 = false;
	public bool inc185 = false;
	public bool inc186 = false;
	public bool inc187 = false;
	public bool inc188 = false;
	public bool inc189 = false;
	public bool inc190 = false;
	public bool inc191 = false;
	public bool inc192 = false;
	public bool inc193 = false;
	
	
	
	private bool nextButton;
	
	//private float cutsceneNextTime = 0.0f;
	//private float cutsceneNextDelay = 2.0f;
	//Time curTime;
	//private float curTime = 0.0f;
	
	//private bool timeToShowCutscenes = true;
	private float cutscenesTimeDuration = 12.0f;
	
	
	
	public Rect rect;// = new Rect(Screen.width, Screen.height, 1320.0f, 1320.0f);
	//public Rect rect = new Rect(
	
	
	
	//Yes or No for ending:
	private bool bringIchikoToFuture;
	private bool followGeneralsOrders;
	private bool nextButton2;//Used from now on when decision above is made



	public ParticleSystem atomicExplosion1;
	public ParticleSystem atomicExplosion2;
	public ParticleSystem atomicExplosion3;
	public ParticleSystem atomicExplosion4;
	public ParticleSystem atomicExplosion5;


	
	
	// Use this for initialization
	void Start () {
		
		
		//player = GameObject.FindGameObjectWithTag("Player");
		//player = GameObject.FindWithTag("Player");
		//level = 0;
		
		inichiko = false;
		inichikohair2 = false;
		inichikoHandsBack = false;
		inichikoSmile = false;
		inichikoCloseEye = false;
		inichikoNewDress = false;
		inichikoNewDressver2 = false;
		inichikoNewDressCloseEye = false;
		inichikoNewDressCloseEyever2 = false;
		inichikoNewDressSmileCloseEyeNightver2 = false;
		inichikoNormalHandsBackSmileCloseEye = false;
		
		
		
		
		
		
		
		insketch1 = false;
		insketch2 = false;
		insketch3 = false;//sketch 17 winter
		insketch3ver2 = false; //sketch 17 winter version 2
		insketch4spring = false;
		insketch4summer = false;
		insketch4winter = false;
		insketch5spring = false;
		insketch5summer = false;
		insketch5winter = false;
		insketch6spring = false;
		insketch6summer = false;
		insketch6winter = false;
		insketch7yr1944winter = false;
		insketch7yr1944 = false;
		insketch7yr2242 = false;
		insketch7yr2242ver2 = false;
		insketch7yr2242ver3 = false;
		insketch10 = false;
		insketch11 = false;
		insketch13 = false;
		insketch13ver2 = false;
		insketch14 = false;
		insketch15 = false;
		insketch15ver2 = false;
		insketch16 = false;
		insketch16ver2 = false;
		insketch17 = false;//sketch 17 summer
		insketch17ver2 = false;
		insketch18 = false;
		insketch18ver2 = false;
		insketch18ver3 = false;
		insketch18ver4 = false;
		insketch19 = false;
		insketch19ver2 = false;
		insketch20 = false;
		insketch20night = false;
		insketch20ver2 = false;
		insketch21 = false;
		
		
		//inc12 = false;
		inc12 = true;
		inc13 = false;
		inc14 = false;
		inc15 = false;
		inc16 = false;
		inc17 = false;
		inc18 = false;
		inc19 = false;
		inc20 = false;
		inc21 = false;
		inc22 = false;
		inc23 = false;
		inc24 = false;
		inc25 = false;
		inc26 = false;
		inc27 = false;
		inc28 = false;
		inc29 = false;
		inc30 = false;
		inc31 = false;
		inc32 = false;
		inc33 = false;
		inc34 = false;
		inc35 = false;
		inc36 = false;
		inc37 = false;
		inc38 = false;
		inc39 = false;
		inc40 = false;
		inc41 = false;
		inc42 = false;
		inc43 = false;
		inc44 = false;
		inc45 = false;
		inc46 = false;
		inc47 = false;
		inc48 = false;
		inc49 = false;
		inc50 = false;
		inc51 = false;
		inc52 = false;
		inc53 = false;
		inc54 = false;
		inc55 = false;
		inc56 = false;
		inc57 = false;
		inc58 = false;
		inc59 = false;
		inc60 = false;
		inc61 = false;
		inc62 = false;
		inc63 = false;
		inc64 = false;
		inc65 = false;
		inc66 = false;
		inc67 = false;
		inc68 = false;
		inc69 = false;
		inc70 = false;
		inc71 = false;
		inc72 = false;
		inc73 = false;
		inc74 = false;
		inc75 = false;
		inc76 = false;
		inc77 = false;
		inc78 = false;
		inc79 = false;
		inc80 = false;
		inc81 = false;
		inc82 = false;
		inc83 = false;
		inc84 = false;
		inc85 = false;
		inc86 = false;
		inc87 = false;
		inc88 = false;
		inc89 = false;
		inc90 = false;
		inc91 = false;
		inc92 = false;
		inc93 = false;
		inc94 = false;
		inc95 = false;
		inc96 = false;
		inc97 = false;
		inc98 = false;
		inc99 = false;
		inc100 = false;
		inc101 = false;
		inc102 = false;
		inc103 = false;
		inc104 = false;
		inc105 = false;
		inc106 = false;
		inc107 = false;
		inc108 = false;
		inc109 = false;
		inc110 = false;
		inc111 = false;
		inc112 = false;
		inc113 = false;
		inc114 = false;
		inc115 = false;
		inc116 = false;
		inc117 = false;
		inc118 = false;
		inc119 = false;
		inc120 = false;
		inc121 = false;
		inc122 = false;
		inc123 = false;
		inc124 = false;
		inc125 = false;
		inc126 = false;
		inc127 = false;
		inc128 = false;
		inc129 = false;
		inc130 = false;
		inc131 = false;
		inc132 = false;
		inc133 = false;
		inc134 = false;
		inc135 = false;
		inc136 = false;
		inc137 = false;
		inc138 = false;
		inc139 = false;
		inc140 = false;
		inc141 = false;
		inc142 = false;
		inc143 = false;
		inc144 = false;
		inc145 = false;
		inc146 = false;
		inc147 = false;
		inc148 = false;
		inc149 = false;
		inc150 = false;
		inc151 = false;
		inc152 = false;
		inc153 = false;
		inc154 = false;
		inc155 = false;
		inc156 = false;
		inc157 = false;
		inc158 = false;
		inc159 = false;
		inc160 = false;
		inc161 = false;
		inc162 = false;
		inc163 = false;
		inc164 = false;
		inc165 = false;
		inc166 = false;
		inc167 = false;
		inc168 = false;
		inc169 = false;
		inc170 = false;
		inc171 = false;
		inc172 = false;
		inc173 = false;
		inc174 = false;
		inc175 = false;
		inc176 = false;
		inc177 = false;
		inc178 = false;
		inc179 = false;
		inc180 = false;
		inc181 = false;
		inc182 = false;
		inc183 = false;
		inc184 = false;
		inc185 = false;
		inc186 = false;
		inc187 = false;
		inc188 = false;
		inc189 = false;
		inc190 = false;
		inc191 = false;
		inc192 = false;
		inc193 = false;
		
		
		
		
		nextButton = false;
		
		//curTime = Time.time;
		
		atomicExplosion1.enableEmission = false;
		atomicExplosion2.enableEmission = false;
		atomicExplosion3.enableEmission = false;
		atomicExplosion4.enableEmission = false;
		atomicExplosion5.enableEmission = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		
	}
	
	
	//you can try a timer that starts at the time you call the first cutscene, 
	//and if the current time = time + 2 seconds call the next one
	//private bool timeToShowCutscenes = true;
	//private float cutscenesTimeDuration = 2.0f;
	
	void OnGUI()
	{
		rect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);
		
		if(SpawnManager.currentWave == 0)
		{
			//GUI.
			//GUI.DrawTexture (rect, sketch1, ScaleMode.ScaleToFit);
			//GUI.DrawTexture (rect, sketch1);
			//Time.timeScale = 0;//Whenever you do this, you effectively cause a bool to pause the game
			
			//level = 1;
			SpawnManager.isCutsceneReady = true;
			
		}
		else if(SpawnManager.currentWave == 1)
		{
			
			
			//Cutscene code just like in Intro.cs
			
			//GUI.DrawTexture (rect, sketch1);
			if(inc12 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				//GUI.DrawTexture (rect, sketch1);
				GUI.DrawTexture (rect, c12);
				
				//
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
				Player.empEnabled = false;
				Enemy.empEnabled = false;				
				Time.timeScale = 0;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)// 
			{
				inc12 = false;
				inc13 = true;
				
				
				//
				//buttonPressed = false;
				nextButton = false;
				
				//cutscenesTimeDuration = 5.0f;//reset//Can reset to any time limit appropriate!
				cutscenesTimeDuration = 8.0f;
			}
			
			
			
			
			if(inc13 == true)
			{
				
				GUI.DrawTexture (rect, sketch18);
				//GUI.DrawTexture (rect, sketch1);
				GUI.DrawTexture (rect, c13);
				
				//
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc13 = false;
				inc14 = true;
				
				
				//
				//buttonPressed = false;
				nextButton = false;
				
				//cutscenesTimeDuration = 5.0f;
				cutscenesTimeDuration = 2.0f;
				
			}
			
			
			
			
			
			
			if(inc14 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c14);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc14 = false;
				inc15 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 15.0f;
				
			}
			
			
			
			
			if(inc15 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c15);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc15 = false;
				inc16 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 20.0f;
				
			}
			
			
			
			
			
			if(inc16 == true)
			{
				
				
				//GUI.DrawTexture (rect, sketch1);
				//GUI.DrawTexture (rect, c13);
				
				//
				//nextButton = GUI.Button(new Rect(75,70,100,50),"Next");
				
				//GUI.DrawTexture (rect, null);
				
				Time.timeScale = 1;
				
				Player.empEnabled = true;
				Enemy.empEnabled = true;
				
				inc16 = false;
				allowPause = true;
				
				
				
				SpawnManager.isCutsceneReady = true;
			}
			
			
		}
		
		else if(SpawnManager.currentWave == 2)
		{
			if (allowPause) {
				inc16 = true;
				allowPause = false;
			}
			//GUI.DrawTexture (rect, sketch18);
			
			if(inc16 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c16);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
				Player.empEnabled = false;
				Enemy.empEnabled = false;
				Time.timeScale = 0;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc16 = false;
				inc17 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 20.0f;
				
			}
			
			
			
			if(inc17 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c17);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc17 = false;
				inc18 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 10.0f;
				
			}
			
			
			
			if(inc18 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c18);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc18 = false;
				inc19 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 4.0f;
				
			}
			
			
			
			
			if(inc19 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c19);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				GUI.DrawTexture (rect, sketch18);
				inc19 = false;
				inc20 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 20.0f;
				
				
				//Time.timeScale = 1;
				
			}
			
			
			
			
			if(inc20 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c20);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc20 = false;
				inc21 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 10.0f;
				
			}
			
			
			
			
			if(inc21 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c21);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc21 = false;
				inc22 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 20.0f;
				
			}
			
			
			
			if(inc22 == true)
			{
				
				
				//GUI.DrawTexture (rect, sketch1);
				//GUI.DrawTexture (rect, c13);
				
				//
				//nextButton = GUI.Button(new Rect(75,70,100,50),"Next");
				
				//GUI.DrawTexture (rect, null);
				
				
				
				
				Time.timeScale = 1;
				Player.empEnabled = true;
				Enemy.empEnabled = true;			
				
				Time.timeScale = 1;
				inc22 = false;
				allowPause2 = true;
				
				
				SpawnManager.isCutsceneReady = true;
			}
			
			
			
		}
		else if(SpawnManager.currentWave == 3)
		{
			
			if (allowPause2) {
				inc22 = true;
				allowPause2 = false;
			}
			if(inc22 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c22);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
				Player.empEnabled = false;
				Enemy.empEnabled = false;
				Time.timeScale = 0;
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc22 = false;
				inc23 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 8.0f;
				
			}
			
			
			
			if(inc23 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c23);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc23 = false;
				inc24 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 15.0f;
				
			}
			
			
			
			
			if(inc24 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c24);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc24 = false;
				inc25 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 4.0f;
				
			}
			
			
			
			if(inc25 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c25);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc25 = false;
				inc26 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 4.0f;
				
			}
			
			
			
			
			if(inc26 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c26);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc26 = false;
				inc27 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 20.0f;
				
			}
			
			
			
			
			if(inc27 == true)
			{
				
				
				//GUI.DrawTexture (rect, sketch1);
				//GUI.DrawTexture (rect, c13);
				
				//
				//nextButton = GUI.Button(new Rect(75,70,100,50),"Next");
				
				//GUI.DrawTexture (rect, null);
				
				
				Time.timeScale = 1;
				
				Player.empEnabled = true;
				Enemy.empEnabled = true;
				
				inc27 = false;
				allowPause3 = true;
				
				
				
				SpawnManager.isCutsceneReady = true;
				
			}
			
			
			//To pause game:  Time.timeScale = 1;
			//ignoring sketch 18
			
			//27-30 cutscenes during level 2
			//31-73 cutscenes between level 2 and level 3
			
			
			
			
		}
		
		//Level 2 Begins
		else if(SpawnManager.currentWave == 4)
		{
			
			/*if(level == 1){
				player.transform.position = new Vector3(3788.0f, 75.0f, 25440.0f);
				level = 2;
			}*/
			
			if (allowPause3) {
				
				inc27 = true;
				allowPause3 = false;
			}
			if(inc27 == true)
			{
				//SpawnManager.playerSpawned = false;


				GUI.DrawTexture (rect, sketch18ver4);
				GUI.DrawTexture (rect, c27);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
				
				Player.empEnabled = false;
				Enemy.empEnabled = false;
				Time.timeScale = 0;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc27 = false;
				inc28 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 10.0f;
				
			}
			
			
			
			
			if(inc28 == true)
			{
				GUI.DrawTexture (rect, sketch18ver4);
				GUI.DrawTexture (rect, c28);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc28 = false;
				inc29 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 15.0f;
				
			}
			
			
			
			
			if(inc29 == true)
			{
				GUI.DrawTexture (rect, sketch18ver4);
				GUI.DrawTexture (rect, c29);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc29 = false;
				inc30 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 3.0f;
				
			}
			
			
			
			
			if(inc30 == true)
			{
				GUI.DrawTexture (rect, sketch18ver4);
				GUI.DrawTexture (rect, c30);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc30 = false;
				inc31 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 20.0f;//inc74
				
				
				
				Time.timeScale = 1;
				Player.empEnabled = true;
				Enemy.empEnabled = true;	


				//SpawnManager.playerSpawned = true;

				
				SpawnManager.isCutsceneReady = true;
			}
			
			
			
		}
		else if(SpawnManager.currentWave == 5)
		{
			
			
			SpawnManager.isCutsceneReady = true;
		}
		else if(SpawnManager.currentWave == 6)
		{
			
			
			SpawnManager.isCutsceneReady = true;
		}
		
		
		//Level 3 Begins
		else if(SpawnManager.currentWave == 7)
		{
			//Before level 3 begins:
			
			//Time.timeScale = 0;//pause
			
			
			
			if(inc31 == true)
			{
				//SpawnManager.playerSpawned = false;


				GUI.DrawTexture(rect, sketch18ver4);
				GUI.DrawTexture (rect, c31);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				Player.empEnabled = false;
				Enemy.empEnabled = false;	
				Time.timeScale = 0;
			}
			
			if(nextButton)//  
			{
				inc31 = false;
				inc32 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc32 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect, c32);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc32 = false;
				inc33 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc33 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect, c33);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc33 = false;
				inc34 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc34 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect, c34);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc34 = false;
				inc35 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc35 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect, c35);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc35 = false;
				inc36 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			if(inc36 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect, c36);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc36 = false;
				inc37 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc37 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect, c37);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc37 = false;
				inc38 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc38 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect, c38);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc38 = false;
				inc39 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc39 == true)
			{
				GUI.DrawTexture(rect, sketch3ver2);//sketch17 winter version 2
				GUI.DrawTexture (rect, c39);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc39 = false;
				inc40 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			if(inc40 == true)
			{
				GUI.DrawTexture(rect, sketch3ver2);//sketch17 winter version 2
				GUI.DrawTexture (rect, c40);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc40 = false;
				inc41 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			if(inc41 == true)
			{
				GUI.DrawTexture(rect, sketch4winter);
				GUI.DrawTexture (rect, c41);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc41 = false;
				inc42 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc42 == true)
			{
				GUI.DrawTexture(rect, sketch4winter);
				GUI.DrawTexture (rect, c42);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc42 = false;
				inc43 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc43 == true)
			{
				GUI.DrawTexture(rect, sketch4winter);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c43);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc43 = false;
				inc44 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			
			if(inc44 == true)
			{
				GUI.DrawTexture(rect, sketch4winter);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c44);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc44 = false;
				inc45 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc45 == true)
			{
				GUI.DrawTexture(rect, sketch4winter);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c45);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc45 = false;
				inc46 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc46 == true)
			{
				GUI.DrawTexture(rect, sketch4winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c46);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc46 = false;
				inc47 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc47 == true)
			{
				GUI.DrawTexture(rect, sketch4winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c47);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc47 = false;
				inc48 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc48 == true)
			{
				GUI.DrawTexture(rect, sketch4winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c48);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc48 = false;
				inc49 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			
			if(inc49 == true)
			{
				GUI.DrawTexture(rect, sketch4winter);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c49);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc49 = false;
				inc50 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc50 == true)
			{
				GUI.DrawTexture(rect, sketch5winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c50);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc50 = false;
				inc51 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc51 == true)
			{
				GUI.DrawTexture(rect, sketch5winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c51);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc51 = false;
				inc52 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			
			if(inc52 == true)
			{
				GUI.DrawTexture(rect, sketch5winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c52);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc52 = false;
				inc53 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc53 == true)
			{
				GUI.DrawTexture(rect, sketch5winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c53);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc53 = false;
				inc54 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc54 == true)
			{
				GUI.DrawTexture(rect, sketch5winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c54);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc54 = false;
				inc55 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc55 == true)
			{
				GUI.DrawTexture(rect, sketch5winter);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c55);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc55 = false;
				inc56 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			if(inc56 == true)
			{
				GUI.DrawTexture (rect, sketch4winter);
				GUI.DrawTexture (rect, c56);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc56 = false;
				inc57 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			
			if(inc57 == true)
			{
				GUI.DrawTexture (rect, sketch4winter);
				GUI.DrawTexture (rect, c57);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc57 = false;
				inc58 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			
			
			if(inc58 == true)
			{
				GUI.DrawTexture (rect, sketch6winter);
				GUI.DrawTexture (rect, c58);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc58 = false;
				inc59 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc59 == true)
			{
				GUI.DrawTexture (rect, sketch6winter);
				GUI.DrawTexture (rect, c59);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc59 = false;
				inc60 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc60 == true)
			{
				GUI.DrawTexture (rect, sketch6winter);
				GUI.DrawTexture (rect, c60);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc60 = false;
				inc61 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc61 == true)
			{
				GUI.DrawTexture (rect, sketch6winter);
				GUI.DrawTexture (rect, c61);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc61 = false;
				inc62 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			if(inc62 == true)
			{
				GUI.DrawTexture (rect, sketch6winter);
				GUI.DrawTexture (rect, c62);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc62 = false;
				inc63 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc63 == true)
			{
				GUI.DrawTexture (rect, sketch6winter);
				GUI.DrawTexture (rect, c63);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc63 = false;
				inc64 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc64 == true)
			{
				GUI.DrawTexture (rect, sketch6winter);
				GUI.DrawTexture (rect, c64);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc64 = false;
				inc65 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc65 == true)
			{
				GUI.DrawTexture (rect, sketch6winter);
				GUI.DrawTexture (rect, c65);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc65 = false;
				inc66 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc66 == true)
			{
				GUI.DrawTexture (rect, sketch6winter);
				GUI.DrawTexture (rect, c66);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc66 = false;
				inc67 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc67 == true)
			{
				GUI.DrawTexture (rect, sketch6winter);
				GUI.DrawTexture (rect, c67);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc67 = false;
				inc68 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc68 == true)
			{
				GUI.DrawTexture (rect, sketch5winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c68);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc68 = false;
				inc69 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc69 == true)
			{
				GUI.DrawTexture (rect, sketch5winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c69);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc69 = false;
				inc70 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			if(inc70 == true)
			{
				GUI.DrawTexture (rect, sketch5winter);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c70);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc70 = false;
				inc71 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc71 == true)
			{
				GUI.DrawTexture (rect, sketch5winter);
				GUI.DrawTexture (rect, c71);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc71 = false;
				inc72 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
			}
			
			
			
			
			if(inc72 == true)
			{
				GUI.DrawTexture (rect, sketch7yr1944winter);
				GUI.DrawTexture (rect, c72);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc72 = false;
				inc73 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 20.0f;//inc74
				
				
			}
			
			
			
			
			if(inc73 == true)
			{
				GUI.DrawTexture (rect, sketch7yr1944winter);
				GUI.DrawTexture (rect, c73);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(nextButton)//  
			{
				inc73 = false;
				inc74 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 20.0f;//inc74
				
				//Time.timeScale = 1;//Resume
				
			}
			
			
			
			
			
			
			
			
			
			//After Briefing:
			
			
			if(inc74 == true)
			{
				GUI.DrawTexture (rect, sketch18);
				GUI.DrawTexture (rect, c74);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc74 = false;
				inc75 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 8.0f;//inc74
				
			}
			
			
			
			
			if(inc75 == true)
			{
				GUI.DrawTexture (rect, sketch18ver4);
				GUI.DrawTexture (rect, c75);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc75 = false;
				inc76 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 25.0f;//inc74
				
			}
			
			
			
			
			
			if(inc76 == true)
			{
				GUI.DrawTexture (rect, sketch18ver4);
				GUI.DrawTexture (rect, c76);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc76 = false;
				inc77 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc77 == true)
			{
				GUI.DrawTexture (rect, sketch18ver4);
				GUI.DrawTexture (rect, c77);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc77 = false;
				inc78 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc78 == true)
			{
				GUI.DrawTexture (rect, null);
				//nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				
				Time.timeScale = 1;
				Player.empEnabled = true;
				Enemy.empEnabled = true;	



				//SpawnManager.playerSpawned = true;
				
				SpawnManager.isCutsceneReady = true;
			}
			
			
		}
		else if(SpawnManager.currentWave == 8)
		{
			
			
			SpawnManager.isCutsceneReady = true;
		}
		else if(SpawnManager.currentWave == 9)
		{
			
			
			SpawnManager.isCutsceneReady = true;
		}
		else if(SpawnManager.currentWave == 10)
		{
			
			
			SpawnManager.isCutsceneReady = true;
		}
		
		
		//Level 4 Begins
		else if(SpawnManager.currentWave == 11)
		{
			
			/*if(level == 3){
				player.transform.position = new Vector3(-18494.0f, 18.0f, 4213.0f);
				level = 4;
			}*/
			
			//Briefing before level 4  78-128
			if(inc78 == true)
			{

				//SpawnManager.playerSpawned = false;


				GUI.DrawTexture (rect, sketch18ver4);
				GUI.DrawTexture (rect, c78);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				Player.empEnabled = false;
				Enemy.empEnabled = false;	
				Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc78 = false;
				inc79 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc79 == true)
			{
				GUI.DrawTexture (rect, sketch18ver4);
				GUI.DrawTexture (rect, c79);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc79 = false;
				inc80 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc80 == true)
			{
				GUI.DrawTexture (rect, sketch18ver4);
				GUI.DrawTexture (rect, c80);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc80 = false;
				inc81 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc81 == true)
			{
				GUI.DrawTexture (rect, sketch4spring);
				GUI.DrawTexture (rect, c81);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc81 = false;
				inc82 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc82 == true)
			{
				GUI.DrawTexture (rect, sketch4spring);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c82);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc82 = false;
				inc83 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc83 == true)
			{
				GUI.DrawTexture (rect, sketch4spring);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c83);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc83 = false;
				inc84 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			if(inc84 == true)
			{
				GUI.DrawTexture (rect, sketch4spring);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c84);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc84 = false;
				inc85 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			if(inc85 == true)
			{
				GUI.DrawTexture (rect, sketch4spring);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c85);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc85 = false;
				inc86 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc86 == true)
			{
				GUI.DrawTexture (rect, sketch5spring);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c86);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc86 = false;
				inc87 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc87 == true)
			{
				GUI.DrawTexture (rect, sketch5spring);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c87);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc87 = false;
				inc88 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc88 == true)
			{
				GUI.DrawTexture (rect, sketch5spring);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c88);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc88 = false;
				inc89 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc89 == true)
			{
				GUI.DrawTexture (rect, sketch5spring);
				GUI.DrawTexture (rect, ichikoHandsBack);
				GUI.DrawTexture (rect, c89);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc89 = false;
				inc90 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			
			if(inc90 == true)
			{
				GUI.DrawTexture (rect, sketch5spring);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c90);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc90 = false;
				inc91 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			
			if(inc91 == true)
			{
				GUI.DrawTexture (rect, sketch5spring);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c91);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc91 = false;
				inc92 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc92 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect, c92);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc92 = false;
				inc93 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc93 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c93);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc93 = false;
				inc94 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc94 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect,ichikoHandsBack);
				GUI.DrawTexture (rect, c94);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc94 = false;
				inc95 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc95 == true)
			{
				GUI.DrawTexture(rect, sketch21);
				GUI.DrawTexture (rect,ichikoHandsBack);
				GUI.DrawTexture (rect, c95);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc95 = false;
				inc96 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			if(inc96 == true)
			{
				GUI.DrawTexture(rect, sketch18ver4);
				GUI.DrawTexture (rect,ichikoSmile);
				GUI.DrawTexture (rect, c96);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc96 = false;
				inc97 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc97 == true)
			{
				GUI.DrawTexture(rect, sketch18ver4);
				GUI.DrawTexture (rect,ichikoSmile);
				GUI.DrawTexture (rect, c97);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc97 = false;
				inc98 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			if(inc98 == true)
			{
				GUI.DrawTexture(rect, sketch18ver4);
				GUI.DrawTexture (rect, ichikoCloseEye);
				GUI.DrawTexture (rect, c98);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc98 = false;
				inc99 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc99 == true)
			{
				GUI.DrawTexture(rect, sketch18ver4);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c99);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc99 = false;
				inc100 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc100 == true)
			{
				GUI.DrawTexture(rect, sketch18ver4);
				GUI.DrawTexture (rect, ichikoNormalHandsBackSmileCloseEye);
				GUI.DrawTexture (rect, c100);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc100 = false;
				inc101 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc101 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c101);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc101 = false;
				inc102 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc102 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c102);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc102 = false;
				inc103 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc103 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c103);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc103 = false;
				inc104 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc104 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c104);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc104 = false;
				inc105 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc105 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c105);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc105 = false;
				inc106 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc106 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c106);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc106 = false;
				inc107 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc107 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c107);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc107 = false;
				inc108 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc108 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c108);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc108 = false;
				inc109 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc109 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c109);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc109 = false;
				inc110 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc110 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c110);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc110 = false;
				inc111 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc111 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c111);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc111 = false;
				inc112 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc112 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c112);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc112 = false;
				inc113 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc113 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c113);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc113 = false;
				inc114 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc114 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c114);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc114 = false;
				inc115 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc115 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c115);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc115 = false;
				inc116 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc116 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c116);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc116 = false;
				inc117 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc117 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c117);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc117 = false;
				inc118 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc118 == true)
			{
				GUI.DrawTexture (rect, sketch6spring);
				GUI.DrawTexture (rect, c118);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc118 = false;
				inc119 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc119 == true)
			{
				GUI.DrawTexture (rect, sketch5summer);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c119);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc119 = false;
				inc120 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc120 == true)
			{
				GUI.DrawTexture (rect, sketch5summer);
				GUI.DrawTexture (rect, ichikoSmile);
				GUI.DrawTexture (rect, c120);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc120 = false;
				inc121 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			
			if(inc121 == true)
			{
				GUI.DrawTexture (rect, sketch5summer);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c121);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc121 = false;
				inc122 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc122 == true)
			{
				GUI.DrawTexture (rect, sketch5summer);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c122);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc122 = false;
				inc123 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			
			if(inc123 == true)
			{
				GUI.DrawTexture (rect, sketch5summer);
				GUI.DrawTexture (rect, ichiko);
				GUI.DrawTexture (rect, c123);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc123 = false;
				inc124 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			
			if(inc124 == true)
			{
				GUI.DrawTexture (rect, sketch17ver2);
				GUI.DrawTexture (rect, c124);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc124 = false;
				inc125 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc125 == true)
			{
				GUI.DrawTexture (rect, sketch6summer);
				GUI.DrawTexture (rect, c125);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc125 = false;
				inc126 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			
			if(inc126 == true)
			{
				GUI.DrawTexture (rect, sketch6summer);
				GUI.DrawTexture (rect, c126);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc126 = false;
				inc127 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc127 == true)
			{
				GUI.DrawTexture (rect, sketch6summer);
				GUI.DrawTexture (rect, c127);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc127 = false;
				inc128 = true;
				
				nextButton = false;
				
				//cutscenesTimeDuration = 15.0f;//inc74
				
			}
			
			
			
			
			if(inc128 == true)
			{
				GUI.DrawTexture (rect, sketch10);
				GUI.DrawTexture (rect, c128);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			//if(cutscenesTimeDuration <= 0.0f || nextButton)//
			if(nextButton)
			{
				inc128 = false;
				inc129 = true;
				
				nextButton = false;
				
				Time.timeScale = 1;
				Player.empEnabled = true;
				Enemy.empEnabled = true;	
				cutscenesTimeDuration = 15.0f;//inc129
				
			}
			
			SpawnManager.isCutsceneReady = true;
			
			
			//Level 4 begins here
			
			//There are no cutscenes during gameplay for level 4 wave 1
			
			
			
			
			
		}
		else if(SpawnManager.currentWave == 12)
		{
			
			
			SpawnManager.isCutsceneReady = true;
		}
		else if(SpawnManager.currentWave == 13)
		{
			
			
			SpawnManager.isCutsceneReady = true;
		}
		else if(SpawnManager.currentWave == 14)
		{
			atomicExplosion1.enableEmission = true;
			atomicExplosion2.enableEmission = true;
			atomicExplosion3.enableEmission = true;
			atomicExplosion4.enableEmission = true;

			SpawnManager.isCutsceneReady = true;
		}
		else if(SpawnManager.currentWave == 15)
		{
			

			atomicExplosion1.enableEmission = true;
			atomicExplosion2.enableEmission = true;
			atomicExplosion3.enableEmission = true;
			atomicExplosion4.enableEmission = true;
			atomicExplosion5.enableEmission = true;	

			SpawnManager.isCutsceneReady = true;
		}
		
		
		//If Last Wave finally defeated
		else if(SpawnManager.currentWave == 16)
		{
			
			
			if(inc129 == true)
			{
				GUI.DrawTexture (rect, sketch18ver2);
				GUI.DrawTexture (rect, c129);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				Player.empEnabled = false;
				Enemy.empEnabled = false;	
				Time.timeScale = 0;
				
			}
			
			if(nextButton)//
			{
				inc129 = false;
				inc130 = true;
				
				nextButton = false;
				
				
				//cutscenesTimeDuration = 15.0f;//inc129
				
			}
			
			
			
			
			
			if(inc130 == true)
			{
				GUI.DrawTexture (rect, sketch18ver2);
				GUI.DrawTexture (rect, c130);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			if(nextButton)//
			{
				inc130 = false;
				inc131 = true;
				
				nextButton = false;
				
				//Time.timeScale = 1;
				
				//cutscenesTimeDuration = 15.0f;//inc129
				
			}
			
			
			
			
			if(inc131 == true)
			{
				GUI.DrawTexture (rect, sketch18ver2);
				GUI.DrawTexture (rect, c131);
				nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			if(nextButton)//
			{
				inc131 = false;
				inc132 = true;
				
				nextButton = false;
				
				//Time.timeScale = 1;
				
				//cutscenesTimeDuration = 15.0f;//inc129
				
			}
			
			
			
			//Making your decision:
			
			if(inc132 == true)
			{
				GUI.DrawTexture (rect, sketch18ver2);
				GUI.DrawTexture (rect, c131);
				//nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 200,100,50),"Next");
				//private bool bringIchikoToFuture;
				//private bool followGeneralsOrders;
				bringIchikoToFuture = GUI.Button(new Rect((Screen.width/2)-200,(Screen.height/2)-100,400,50),"Bring Ichiko to future with you.");
				followGeneralsOrders = GUI.Button(new Rect((Screen.width/2)-200,(Screen.height/2)+50,400,50),"Follow General Erickson's orders.");
				
				
				
				//cutscenesTimeDuration -= Time.deltaTime;
				//Time.timeScale = 0;
				
			}
			
			if(bringIchikoToFuture)//
			{
				inc132 = false;
				inc143 = true;
				
				Application.LoadLevel("SaveIchiko");
				
				//nextButton = false;
				
				//Time.timeScale = 1;
				
				//cutscenesTimeDuration = 15.0f;//inc129
				
			}
			else if (followGeneralsOrders)
			{
				inc132 = false;
				inc133 = true;
				
				Application.LoadLevel("FollowOrders");
				
				
				
				SpawnManager.isCutsceneReady = true;
			}
			
			
			
			
		}
		
		
		
	}
	
	
	
	
}
