using UnityEngine;
using System.Collections;

public class aspects : MonoBehaviour {
	public bool red;
	public GameObject player;
	public GameObject playercam;
	public GameObject playerfootbox;
    bool switched;
    bool grounded;
    public bool canswitch;

    float cd;
    float cdtimer;
    bool oncd;

    public player playerscript;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();
        canswitch = true;
        cdtimer = 1;
    }
	
	// Update is called once per frame
	void Update () {

        if (oncd)
        {
            cd -= Time.deltaTime;
            if (cd <= 0)
            {
                oncd = false;
            }
        }

        grounded = playerscript.grounded;
        if(grounded == true)
        {
            if(switched == true)
            {
                switched = false;
            }
        }

        if (!switched)
        {
            if (oncd == false)
            {
				if (!playerscript.rooted) {
                    if (canswitch) {
                        if (Input.GetKeyDown(KeyCode.Q))
                        {
                            if (red)
                            {
                                red = false;
                                player.layer = LayerMask.NameToLayer("bluePlayer");
                                playerfootbox.layer = LayerMask.NameToLayer("bluePlayer");
                                switched = true;
                                oncd = true;
                                cd = cdtimer;
                            }
                            else if (!red)
                            {
                                red = true;
                                player.layer = LayerMask.NameToLayer("redPlayer");
                                playerfootbox.layer = LayerMask.NameToLayer("redPlayer");
                                switched = true;
                                oncd = true;
                                cd = cdtimer;
                            }
                        }
					}
				}
            }
        }
    }
}
