using UnityEngine;
using System.Collections;

public class ability : MonoBehaviour {
    //Attack object
	public GameObject attackObject;
	public GameObject[] attackObjs;

    //Cooldown values
    public float cooldown;
    public bool oncd;
    public float timer;

    //Buttons
    public int buttonid;
    KeyCode button;

    //Game controller and aspects
    public GameObject gamemanager;
    public aspects aspects;
    public bool red;

    //Player 
    public GameObject player;
    public player playerscript;
	public bool rooted;
	public bool holdingWall;

    //mana values
    public float mana;
    public float manaCost;

	//for multiuse abilities
	public bool isMultiUse;
	public int uses;
	public int currentUses;
	public float subCooldown;
	public float subLimit;
	public bool onsubcd;
	public float subTimer;
	public bool isUsing;

    //ability info
    public bool abilityRed;

    // Use this for initialization
    void Start () {
		
        //Get player
        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();
        gamemanager = GameObject.Find("gamemanager");
        aspects = gamemanager.GetComponent<aspects>();

        //Button setters
        if (buttonid == 0)
        {
            button = KeyCode.Alpha1;
        }
        else if (buttonid == 1)
        {
            button = KeyCode.Alpha2;
        }
        else if (buttonid == 2)
        {
            button = KeyCode.Alpha3;
        }

		if (isMultiUse) {
			attackObjs = new GameObject[uses];
			currentUses = uses;
		}
    }
	
	// Update is called once per frame
	void Update () {

        //Get red
        red = aspects.red;

        //Get rooted
        rooted = playerscript.rooted;

		//get wall
		holdingWall = playerscript.holdingWall;

        //Get mana
        if (abilityRed)
        {
            mana = playerscript.redmana;
        }
        else if (!abilityRed)
        {
            mana = playerscript.bluemana;
        }
        
        //Ability

		if (red == abilityRed) {
			if (Input.GetKeyDown (button)) {
				if (!isMultiUse) {
					if (!oncd) {
						if (mana > manaCost) {
							if (!rooted) {
								//Mana stuff
								mana = mana - manaCost;
								if (abilityRed) {
									playerscript.redmana = mana;
								} else if (!abilityRed) {
									playerscript.bluemana = mana;
								}

								abilityStart (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
								timer = cooldown;
								oncd = true;
							}       
						}
					}
				} else {
					if (!oncd) {
						if (!onsubcd) {
							if (currentUses > 0) {
								if ((mana > manaCost) || !isUsing) {
									if (!isUsing) {
										mana = mana - manaCost;
										if (abilityRed) {
											playerscript.redmana = mana;
										} else if (!abilityRed) {
											playerscript.bluemana = mana;
										}
										isUsing = true;
									}
									abilityStart (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
									currentUses--;
									subTimer = subLimit;
									onsubcd = true;
									Debug.Log ("a");
								}
							} else {
								abilityEnd (true);
								timer = cooldown;
								isUsing = false;
								oncd = true;
								Debug.Log ("b");
							}
						}
					}
				}
			}
		} else {
			subTimer = 0;
		}

        //Cooldown Timer
        if (oncd)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                oncd = false;
				currentUses = uses;
                timer = 0;
            }
        }
		if (isUsing) {
			subTimer -= Time.deltaTime;
			if (subTimer <= subLimit-subCooldown) {
				onsubcd = false;

			}
			if (subTimer <= 0)
			{
				abilityEnd (false);
				timer = cooldown;
				isUsing = false;
				oncd = true;
			}
		}
    }

    public virtual void abilityStart(Vector3 pos, Quaternion angle)
    {

    }

	public virtual void abilityEnd(bool wasActivated)
	{

	}
   
}
