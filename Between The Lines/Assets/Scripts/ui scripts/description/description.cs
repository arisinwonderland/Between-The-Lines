using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class description : MonoBehaviour {
	
	descbox descbox;

	Text txt;

	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponentInChildren<Text>();
		descbox = GameObject.Find ("descbox").GetComponent<descbox> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver() {
		if (txt.text != "Empty") {
			descbox.currentDesc = txt.text;
			descbox.hidden = false;
		} else {
			descbox.hidden = true;
		}
	}
	void OnMouseExit() {
		descbox.hidden = true;
	}
}
