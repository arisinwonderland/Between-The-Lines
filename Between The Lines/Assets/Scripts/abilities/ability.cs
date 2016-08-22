using UnityEngine;
using System.Collections;

public class ability : MonoBehaviour {
    //Attack object
    public GameObject attackObject;

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

    //mana values
    public float mana;
    public float manaCost;

    //ability info
    public bool abilityRed;

    // Use this for initialization
    void Start () {

        //Get player
        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();
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

    }
	
	// Update is called once per frame
	void Update () {

        //Get red
        red = aspects.red;

        //Get rooted
        rooted = playerscript.rooted;

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
        if (red == abilityRed)
        {
            if (Input.GetKeyDown(button))
            {
                if (!oncd)
                {
                    if (mana > manaCost)
                    {
                        if (!rooted)
                        {

                            //Mana stuff
                            mana = mana - 20;
                            if (abilityRed)
                            {
                                playerscript.redmana = mana;
                            }
                            else if (!abilityRed)
                            {
                                playerscript.bluemana = mana;
                            }

                            abilityStart(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                            timer = cooldown;
                            oncd = true;
                        }       
                    }
                }
            }
        }

        //Cooldown Timer
        if (oncd)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                oncd = false;
                timer = 0;
            }
        }
    }

    public virtual void abilityStart(Vector3 pos, Quaternion angle)
    {

    }
}
