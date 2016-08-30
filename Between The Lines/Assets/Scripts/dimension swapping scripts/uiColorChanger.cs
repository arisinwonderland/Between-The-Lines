using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class uiColorChanger : MonoBehaviour {
    GameObject gameManager;
    aspects aspects;
	Image image;
	SpriteRenderer sprite;
	Color color;

	public bool isStatic;
	bool red;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("gamemanager");
		aspects = gameManager.GetComponent<aspects>();
		if (isStatic) {
			image = gameObject.GetComponent<Image> ();
		} else {
			sprite = gameObject.GetComponent<SpriteRenderer> ();
		}
    }

	// Update is called once per frame
	void Update () {
		red = aspects.red;
		if (red) {
			color = new Color(90/255F, 0F, 0F);
		} else {
			color = new Color(30F/255F, 30F/255F, 80F/255F);
		}
		if (isStatic) {
			image.color = color;
		} else {
			sprite.color = color;
		}
	}
}
