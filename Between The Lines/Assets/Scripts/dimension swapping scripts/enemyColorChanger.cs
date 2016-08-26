using UnityEngine;
using System.Collections;

public class enemyColorChanger : MonoBehaviour {

	public bool isRed;
	bool red;
	GameObject gamemanager;
    aspects aspects;
	SpriteRenderer sprite;
	Color color;

    // Use this for initialization
	void Start () {
		gamemanager = GameObject.Find("gamemanager");
        aspects = gamemanager.GetComponent<aspects>();
		sprite = GetComponentInChildren<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        red = aspects.red;
		color = sprite.color;

		if (red == isRed) {
			color.a = 1F;
			sprite.color = color;
		} 
		else {
			color.a = 0.3F;
			sprite.color = color;		
		}
    }
}
