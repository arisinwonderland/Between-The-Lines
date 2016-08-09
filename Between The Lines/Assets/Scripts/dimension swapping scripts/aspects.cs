using UnityEngine;
using System.Collections;

public class aspects : MonoBehaviour {
	public bool red;
	public GameObject player;
	public GameObject playercam;
	public GameObject playerfootbox;
    bool switched;
    bool grounded;

    public player playerscript;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();
    }
	
	// Update is called once per frame
	void Update () {

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
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (red)
                {
                    red = false;
                    player.layer = LayerMask.NameToLayer("bluePlayer");
                    playercam.layer = LayerMask.NameToLayer("bluePlayer");
                    playerfootbox.layer = LayerMask.NameToLayer("bluePlayer");
                    switched = true;
                }
                else if (!red)
                {
                    red = true;
                    player.layer = LayerMask.NameToLayer("redPlayer");
                    playercam.layer = LayerMask.NameToLayer("redPlayer");
                    playerfootbox.layer = LayerMask.NameToLayer("redPlayer");
                    switched = true;
                }
            }
        }
    }
}
