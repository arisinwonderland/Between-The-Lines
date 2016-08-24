using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class abilitybar : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = new Vector3 (0.0F, 0.5F, 0F);
		gameObject.transform.position = Camera.main.ViewportToWorldPoint(pos);
	}
}
