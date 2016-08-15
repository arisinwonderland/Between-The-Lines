using UnityEngine;
using System.Collections;

public class beamcolorchanger : MonoBehaviour {

    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;
    public bool isredpart;

    // Use this for initialization
    void Start () {
        gamecontroller = GameObject.Find("GameController");
        aspects = gamecontroller.GetComponent<aspects>();
    }
	
	// Update is called once per frame
	void Update () {

        red = aspects.red;

        if(isredpart == true)
        {
            if (red == true)
            {
                this.GetComponent<ParticleSystem>().startColor = new Color(1, 0, 0, 1f);
            }else
            {
                this.GetComponent<ParticleSystem>().startColor = new Color(1, 0, 0, .25f);
            }

        }

        if (isredpart == false)
        {
            if (red == true)
            {
                this.GetComponent<ParticleSystem>().startColor = new Color(0, 0, 1, .25f);
            }
            else
            {
                this.GetComponent<ParticleSystem>().startColor = new Color(0, 0, 1, 1f);
            }

        }

    }
}
