using UnityEngine;
using System.Collections;

public class backgroundChanger : MonoBehaviour {

    public Sprite redBg;

    public Sprite blueBg;
    public GameObject GameManager;
    public gamemanager gamemanager;
    public aspects aspects;
    public bool red;
    // Use this for initialization
    void Start () {
        GameManager = GameObject.Find("gamemanager");
        gamemanager = GameManager.GetComponent<gamemanager>();
        aspects = GameManager.GetComponent<aspects>();
    }
	
	// Update is called once per frame
	void Update () {
        red = aspects.red;
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        if (red)
        {
            renderer.sprite = redBg;
        }
        if (!red)
        {
            renderer.sprite = blueBg;
        }
    }
}
