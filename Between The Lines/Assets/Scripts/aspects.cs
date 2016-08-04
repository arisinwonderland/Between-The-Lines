using UnityEngine;
using System.Collections;

public class aspects : MonoBehaviour {
	public bool red;
	public GameObject player;
	public GameObject playercam;
	public GameObject playerfootbox;

    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

   

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (red)
            {
                red = false;
                player.layer = LayerMask.NameToLayer("bluePlayer");
                playercam.layer = LayerMask.NameToLayer("bluePlayer");
                playerfootbox.layer = LayerMask.NameToLayer("bluePlayer");
            }
            else if (!red)
            {
                red = true;
                player.layer = LayerMask.NameToLayer("redPlayer");
                playercam.layer = LayerMask.NameToLayer("redPlayer");
                playerfootbox.layer = LayerMask.NameToLayer("redPlayer");
            }
        }
    }
}
