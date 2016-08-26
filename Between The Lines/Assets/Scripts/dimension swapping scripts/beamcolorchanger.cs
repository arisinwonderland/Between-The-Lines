using UnityEngine;
using System.Collections;

public class beamcolorchanger : MonoBehaviour {

    public GameObject gamemanager;
    public aspects aspects;
    public bool red;
    public bool isredpart;

    // Use this for initialization
	void Start () {
		gamemanager = GameObject.Find("gamemanager");
        aspects = gamemanager.GetComponent<aspects>();
    }
	
	// Update is called once per frame
	void Update () {

        red = aspects.red;

        if(isredpart) {
            if (red) {
                this.GetComponent<ParticleSystem>().startColor = new Color(1, 0, 0, 1f);
            } 
			else {
                this.GetComponent<ParticleSystem>().startColor = new Color(1, 0, 0, .25f);
            }
        }

        else {
            if (red) {
                this.GetComponent<ParticleSystem>().startColor = new Color(0, 0, 1, .25f);
            }
            else {
                this.GetComponent<ParticleSystem>().startColor = new Color(0, 0, 1, 1f);
            }

        }

    }
}
