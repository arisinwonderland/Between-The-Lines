using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

    public int hp;
    public bool EnemyRed;
    public GameObject gamemanager;
    public perkManager perkManager;
    public int XPValue;

    // Use this for initialization
    void Start()
    {
       
        perkManager = gamemanager.GetComponent<perkManager>();
    }
	
	// Update is called once per frame
	void Update () {

        if (hp <= 0)
        {
            perkManager.addPoints(EnemyRed, XPValue);
            Destroy(gameObject);
        }

    }

   
}
