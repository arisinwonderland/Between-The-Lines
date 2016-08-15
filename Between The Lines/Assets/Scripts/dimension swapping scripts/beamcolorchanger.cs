using UnityEngine;
using System.Collections;

public class beamcolorchanger : MonoBehaviour {

    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;

    // Use this for initialization
    void Start () {
        gamecontroller = GameObject.Find("GameController");
        aspects = gamecontroller.GetComponent<aspects>();
    }
	
	// Update is called once per frame
	void Update () {

        this.GetComponent<ParticleAnimator>().colorAnimation.Equals(0);

	}
}
