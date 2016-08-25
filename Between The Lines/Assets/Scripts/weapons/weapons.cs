using UnityEngine;
using System.Collections;

public class weapons : MonoBehaviour {

    //Attack object
    public GameObject attackObject;

    //Cooldown values
    public float cooldown;
    public bool oncd;
    public float timer;

    //Game controller and aspects
    public GameObject gamemanager;
    public aspects aspects;
    public bool red;

    //Player 
    public GameObject player;
    public player playerscript;
    public bool rooted;

    //weapon info
    public bool weaponred;

    // Use this for initialization
    void Start () {

        //Get player
        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();
        gamemanager = GameObject.Find("gamemanager");
        aspects = gamemanager.GetComponent<aspects>();

    }

    void Update() { 

    //Get red
    red = aspects.red;

        //Get rooted
        rooted = playerscript.rooted;
        
        //Ability
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (!oncd)
                {
                if(red == weaponred) {
                    if (!rooted){
                        weaponStart(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                        timer = cooldown;
                        oncd = true;
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

    public virtual void weaponStart(Vector3 pos, Quaternion angle)
{

}
}
