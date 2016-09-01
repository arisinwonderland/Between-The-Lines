using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

	//Jumping
	public bool grounded = true;
	public bool isjumping = false;
	public bool midJump = false;
	public bool carryingObject = false;
	public float jumptimer = 0;
	public float startHight;

	//Walljump stuff
	public bool holdingWall = false;
	public bool wallGrabReady = false;
	public float wallJumpTimer = 0;
	public bool isWallJumping = false;
	public bool midWallJump = false;
	bool wallIsRight;

	//rooted
	public bool rooted;

	//Movement
	public float moveSpeed;
	public float currentMoveSpeed;
	public float antiGrav = 25;

	//Feet
	public GameObject feets;
    
	//Game manager init and stats
	public GameObject GameManager;
	public gamemanager gamemanager;
	public aspects aspects;
	public bool red;
	string current;

	//Player stats
	public int hp;
	public int maxhp;
	public float redmana;
	public float redmanaregen;
	public float bluemana;
	public float bluemanaregen;

	//animations
	public GameObject sprite;
	public Animator animator;


	public int levelindex;
	// Use this for initialization
	void Start ()
	{
		//animator init
		sprite = GameObject.Find ("playerSprite");
		animator = sprite.GetComponent<Animator> ();

		rooted = false;

		//game manager init
		GameManager = GameObject.Find ("gamemanager");
		gamemanager = GameManager.GetComponent<gamemanager> ();
		aspects = GameManager.GetComponent<aspects> ();

		//Stats
		maxhp = 100;
		hp = maxhp;
		redmana = 100;
		redmanaregen = 5;
		bluemana = 100;
		bluemanaregen = 5;
		holdingWall = false;
		moveSpeed = 10;
      
		//Ability Init
		RedAbilitiesInit ();
		BlueAbilitiesInit ();
		WeaponsInit ();


	}

	// Update is called once per frame
	void Update ()
	{
		//death
		if (hp <= 0) {
			gamemanager.loadlevel (levelindex);
		}

		//Mana regen
		if (redmana < 100) {
			redmana = redmana + (redmanaregen * Time.deltaTime);
		}
		if (redmana > 100) {
			redmana = 100;
		}
		if (bluemana < 100) {
			bluemana = bluemana + (bluemanaregen * Time.deltaTime);
		}
		if (bluemana > 100) {
			bluemana = 100;
		}

		//Get state
		red = aspects.red;

		//Grounded stuff
		if (grounded) {
  
			midJump = false;
			isjumping = false;


		}

       
		//Movement
		if (holdingWall) {
			gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * 10);
		}

		if (!grounded) {
			currentMoveSpeed = moveSpeed / 1.5f;
		} else if (grounded) {
			currentMoveSpeed = moveSpeed;
		}
        
		if (!rooted) {
			if (!holdingWall) {
				if (!wallGrabReady) {
					if (!midWallJump) {
						//Move left and right
						if (Input.GetKey (KeyCode.A)) {
                         
                            
							transform.eulerAngles = new Vector3 (0, 0, 0);

							if (gameObject.GetComponent<Rigidbody> ().velocity.z < currentMoveSpeed) {
								if (gameObject.GetComponent<Rigidbody> ().velocity.z < 0) {
									gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, gameObject.GetComponent<Rigidbody> ().velocity.y, gameObject.GetComponent<Rigidbody> ().velocity.z / 1.6f);
								}
								gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.forward * 60);
							}
							if (isjumping == false && isWallJumping == false) {
								animator.SetInteger ("animation", 2);
							}
						} else if (Input.GetKey (KeyCode.D)) {
                            
							transform.eulerAngles = new Vector3 (0, -180, 0);
							if (gameObject.GetComponent<Rigidbody> ().velocity.z > -currentMoveSpeed) {
								if (gameObject.GetComponent<Rigidbody> ().velocity.z > 0) {
									gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, gameObject.GetComponent<Rigidbody> ().velocity.y, gameObject.GetComponent<Rigidbody> ().velocity.z / 1.6f);
								}
								gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.back * 60);
							}
							if (isjumping == false && isWallJumping == false) {
								animator.SetInteger ("animation", 2);
							}
						} else {
							gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, gameObject.GetComponent<Rigidbody> ().velocity.y, gameObject.GetComponent<Rigidbody> ().velocity.z / 1.5f);
						}

						if (Input.GetKeyUp (KeyCode.A)) {
							if (isjumping == false && isWallJumping == false) {
								animator.SetInteger ("animation", 1);
							}
						}
						if (Input.GetKeyUp (KeyCode.D)) {
							if (isjumping == false && isWallJumping == false) {
								animator.SetInteger ("animation", 1);
							}
						}
					}
				}
			}
			if (wallGrabReady) {
				if (wallIsRight) {

					//Wall hold
					if (Input.GetKey (KeyCode.D)) {
						if (!grounded) {

							holdingWall = true;
							isjumping = false;
							midJump = false;
							midWallJump = false;
							isWallJumping = false;
                                 

						}
					} else if (Input.GetKey (KeyCode.A)) {

						gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.forward * 60);
						transform.eulerAngles = new Vector3 (0, 0, 0);
						if (isjumping == false && isWallJumping == false) {
							animator.SetInteger ("animation", 2);
						}
						holdingWall = false;
                                

					} else {

						holdingWall = false;
                                

					}
				} else if (!wallIsRight) {

					//Wall hold
					if (Input.GetKey (KeyCode.A)) {
						if (!grounded) {

							holdingWall = true;
							isjumping = false;
							midJump = false;
							midWallJump = false;
							isWallJumping = false;
                            


						}
					} else if (Input.GetKey (KeyCode.D)) {
    
						gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.back * 60);
						transform.eulerAngles = new Vector3 (0, -180, 0);
						if (isjumping == false && isWallJumping == false) {
							animator.SetInteger ("animation", 2);
						}
						holdingWall = false;
                                

					} else {

						holdingWall = false;
                                
					}
				}
			}



			//Jumping
			if (Input.GetKeyDown (KeyCode.Space) && !isjumping) {
				animator.SetInteger ("animation", 5);
				//Regular jump
				if (!holdingWall) {
					if (grounded) {

						isjumping = true;
						jumptimer = 0;
                   
						gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * 350);

					}
				}
				//Wall jump
				if (holdingWall) {
               
					if (!grounded) {
                        
						transform.Rotate (0, 180, 0);
						gameObject.GetComponent<Rigidbody> ().AddRelativeForce (Vector3.up * 750);
						gameObject.GetComponent<Rigidbody> ().AddRelativeForce (Vector3.forward * 250);
						midWallJump = true;
						isWallJumping = true;
					}

				}
			}

			//Regular Jumping
			if (isjumping == true) {
				animator.SetInteger ("animation", 6);
				jumptimer += Time.deltaTime;
				if (jumptimer <= .3f) {
                    
					transform.Translate (Vector3.up * 9 * Time.deltaTime);
				}  
               
          
			}

			//Wall jumping
			if (isWallJumping == true) {

				animator.SetInteger ("animation", 6);
				wallJumpTimer += Time.deltaTime;

				if (midWallJump) {
					if (wallJumpTimer > .20f) {
                        
						midWallJump = false;
					}
				}

				if (wallJumpTimer > .25f) {
                    
                    
					midWallJump = false;
					wallJumpTimer = 0;
					isWallJumping = false;
                        
				}
			}
		}
     

	}

	void RedAbilitiesInit ()
	{
		for (int num = 0; num <= 2; num++) {
			if (num == 0) {
				current = gamemanager.SelectedRedAbility1;
			} else if (num == 1) {
				current = gamemanager.SelectedRedAbility2;
			} else if (num == 2) {
				current = gamemanager.SelectedRedAbility3;
			}

			if (current == "Firebolt") {
				gameObject.GetComponentInChildren<red1> ().enabled = true;

				gameObject.GetComponentInChildren<red1> ().buttonid = num;
			}
			if (current == "Surge of Flame") {
				gameObject.GetComponentInChildren<red2> ().enabled = true;

				gameObject.GetComponentInChildren<red2> ().buttonid = num;
			}
			if (current == "Obsidian Rush") {
				gameObject.GetComponentInChildren<red3> ().enabled = true;

				gameObject.GetComponentInChildren<red3> ().buttonid = num;
			}
			if (current == "Demonic Pillar") {
				gameObject.GetComponentInChildren<red4> ().enabled = true;

				gameObject.GetComponentInChildren<red4> ().buttonid = num;
			}
			if (current == "Cataclysm") {
				gameObject.GetComponentInChildren<red5> ().enabled = true;

				gameObject.GetComponentInChildren<red5> ().buttonid = num;
			}
			if (current == "Ritual Summon") {
				gameObject.GetComponentInChildren<red6> ().enabled = true;

				gameObject.GetComponentInChildren<red6> ().buttonid = num;
			}
			if (current == "Brimstone Blast") {
				gameObject.GetComponentInChildren<red7> ().enabled = true;

				gameObject.GetComponentInChildren<red7> ().buttonid = num;
			}
			if (current == "Pillar Chain") {
				gameObject.GetComponentInChildren<red8> ().enabled = true;

				gameObject.GetComponentInChildren<red8> ().buttonid = num;
			}
			if (current == "Dark Gift") {
				gameObject.GetComponentInChildren<red9> ().enabled = true;

				gameObject.GetComponentInChildren<red9> ().buttonid = num;
			}
		}
	}

	void BlueAbilitiesInit ()
	{
		for (int num = 0; num <= 2; num++) {
			if (num == 0) {
				current = gamemanager.SelectedBlueAbility1;
			} else if (num == 1) {
				current = gamemanager.SelectedBlueAbility2;
			} else if (num == 2) {
				current = gamemanager.SelectedBlueAbility3;
			}

			if (current == "Prism") {
				gameObject.GetComponentInChildren<blue1> ().enabled = true;

				gameObject.GetComponentInChildren<blue1> ().buttonid = num;
			}
			if (current == "Soaring Hope") {
				gameObject.GetComponentInChildren<blue2> ().enabled = true;

				gameObject.GetComponentInChildren<blue2> ().buttonid = num;
			}
			if (current == "Guardian Blade") {
				gameObject.GetComponentInChildren<blue3> ().enabled = true;

				gameObject.GetComponentInChildren<blue3> ().buttonid = num;
			}
			if (current == "Heavenly Wrath") {
				gameObject.GetComponentInChildren<blue4> ().enabled = true;

				gameObject.GetComponentInChildren<blue4> ().buttonid = num;
			}
			if (current == "Halo\'s Reach") {
				gameObject.GetComponentInChildren<blue5> ().enabled = true;

				gameObject.GetComponentInChildren<blue5> ().buttonid = num;
			}
			if (current == "Shards of Eternity") {
				gameObject.GetComponentInChildren<blue6> ().enabled = true;

				gameObject.GetComponentInChildren<blue6> ().buttonid = num;
			}
			if (current == "Celestial Shift") {
				gameObject.GetComponentInChildren<blue7>().enabled = true;

				gameObject.GetComponentInChildren<blue7>().buttonid = num;
			}
			if (current == "Soul Tap") {
				gameObject.GetComponentInChildren<blue8>().enabled = true;

				gameObject.GetComponentInChildren<blue8>().buttonid = num;
			}
			if (current == "Lightning Shock") {
				//gameObject.GetComponentInChildren<blue9>().enabled = true;

				//gameObject.GetComponentInChildren<blue9>().buttonid = num;
			}
            
		}
	}

	void WeaponsInit ()
	{
		if (gamemanager.SelectedRedWeapon == "Bow") {
			gameObject.GetComponentInChildren<bow> ().enabled = true;
			gameObject.GetComponentInChildren<bow> ().weaponred = true;
		} else if (gamemanager.SelectedRedWeapon == "Sword") {
			gameObject.GetComponentInChildren<sword> ().enabled = true;
			gameObject.GetComponentInChildren<sword> ().weaponred = true;
		}

		if (gamemanager.SelectedBlueWeapon == "Bow") {
			gameObject.GetComponentInChildren<bow> ().enabled = true;
			gameObject.GetComponentInChildren<bow> ().weaponred = false;
		} else if (gamemanager.SelectedBlueWeapon == "Sword") {
			gameObject.GetComponentInChildren<sword> ().enabled = true;
			gameObject.GetComponentInChildren<sword> ().weaponred = false;
		}

	}

	void onCollisionEnter (Collision other)
	{
        
	}

	void OnCollisionStay (Collision other)
	{

		if (other.gameObject.CompareTag ("Wall") || other.gameObject.CompareTag ("redwall") || other.gameObject.CompareTag ("bluewall")) {

			//get right or left
			if (other.gameObject.transform.position.z > gameObject.transform.position.z) {
				wallIsRight = false;
			} else {
				wallIsRight = true;
			}
			wallGrabReady = true;
		}   
	}

	void OnCollisionExit (Collision other)
	{
		if (other.gameObject.CompareTag ("Wall") || other.gameObject.CompareTag ("redwall") || other.gameObject.CompareTag ("bluewall")) {
			holdingWall = false;
			wallGrabReady = false;
			if (!holdingWall) {
				gameObject.GetComponent<Rigidbody> ().useGravity = true;
			}
		}
        
	}
}
