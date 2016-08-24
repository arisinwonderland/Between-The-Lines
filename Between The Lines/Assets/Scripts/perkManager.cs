using UnityEngine;
using System.Collections;

public class perkManager : MonoBehaviour {

    public int RedPoints;
    public int BluePoints;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addPoints(bool red, int num)
    {
        if (red)
        {
            RedPoints =+ num;
        }else if (!red)
        {
            BluePoints = +num;
        }
    }
}
