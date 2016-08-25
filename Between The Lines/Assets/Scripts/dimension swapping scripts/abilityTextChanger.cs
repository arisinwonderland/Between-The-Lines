using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class abilityTextChanger : MonoBehaviour {
    
	public int num;

	Text txt;
	GameObject gameManager;
	gamemanager gameManagerScript;
	aspects aspects;

	bool red;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("gamemanager");
		aspects = gameManager.GetComponent<aspects>();
		gameManagerScript = gameManager.GetComponent<gamemanager>();
		txt = gameObject.GetComponentInChildren<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		red = aspects.red;
		switch (num) {
		case 1:
			if (red)
				txt.text = gameManagerScript.SelectedRedAbility1;
			else
				txt.text = gameManagerScript.SelectedBlueAbility1;
			break;
		case 2:
			if (red) 
				txt.text = gameManagerScript.SelectedRedAbility2;
			else 
				txt.text = gameManagerScript.SelectedBlueAbility2;
			break;

		case 3:
			if (red) 
				txt.text = gameManagerScript.SelectedRedAbility3;
			else 
				txt.text = gameManagerScript.SelectedBlueAbility3;
			break;
		default:
			txt.text = "";
			break;
		}
    }
}
