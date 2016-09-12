using UnityEngine;
using System.Collections;

public class perkManager : MonoBehaviour {

    public int RedPoints;
    public int BluePoints;

    public bool red2unlock;
    public bool red3unlock;
    public bool red4unlock;
    public bool red5unlock;
    public bool red6unlock;
    public bool red7unlock;
    public bool red8unlock;
    public bool red9unlock;

    public bool blue2unlock;
    public bool blue3unlock;
    public bool blue4unlock;
    public bool blue5unlock;

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
            RedPoints = RedPoints + num;
        }else if (!red)
        {
            BluePoints = BluePoints + num;
        }
    }

        
}
