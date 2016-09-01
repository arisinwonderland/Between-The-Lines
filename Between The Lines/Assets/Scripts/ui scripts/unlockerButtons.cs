using UnityEngine;
using System.Collections;

public class unlockerButtons : MonoBehaviour {

    public bool red;
    public int cost;
    public GameObject next;
    public bool unlockable;
    public bool unlocked;
    public bool nextunlock;

    public GameObject gamemanager;
    public perkManager perkManager;

    public string buttontag;
	// Use this for initialization
	void Start () {   
        perkManager = gamemanager.GetComponent<perkManager>();
        buttoninit();
    }
	
	// Update is called once per frame
	void Update () {

        if(unlocked)
        {
            Destroy(gameObject);
        }
	
	}

    public void getUnlocked()
    {
        
        if (unlockable) {
            if (red)
            {
                if (perkManager.RedPoints >= cost)
                {
                    perkManager.RedPoints -= cost;
                    unlocked = true;
                    record(buttontag);
                    if (nextunlock)
                    {
                        next.GetComponent<unlockerButtons>().unlockable = true;
                        
                    }
                    
                }
            }
            else if (!red)
            {
                if (perkManager.BluePoints >= cost)
                {
                    perkManager.BluePoints -= cost;
                    unlocked = true;
                    record(buttontag);
                    if (nextunlock)
                    {
                        next.GetComponent<unlockerButtons>().unlockable = true;

                    }
                }
            }
        }
    }

    public void record(string buttontag)
    {
        if(buttontag == "red2")
        {
            perkManager.red2unlock = true;
        }else if(buttontag == "red3")
        {
            perkManager.red3unlock = true;
        }
        else if (buttontag == "red4")
        {
            perkManager.red4unlock = true;
        }
        else if (buttontag == "red5")
        {
            perkManager.red5unlock = true;
        }
        else if (buttontag == "red6")
        {
            perkManager.red6unlock = true;
        }
        else if (buttontag == "red7")
        {
            perkManager.red7unlock = true;
        }
        else if (buttontag == "red8")
        {
            perkManager.red8unlock = true;
        }
        else if (buttontag == "red9")
        {
            perkManager.red9unlock = true;
        }

        if (buttontag == "blue2")
        {
            perkManager.blue2unlock = true;
        }
        else if (buttontag == "blue3")
        {
            perkManager.blue3unlock = true;
        }
        else if (buttontag == "blue4")
        {
            perkManager.blue4unlock = true;
        }
        else if (buttontag == "blue5")
        {
            perkManager.blue5unlock = true;
        }

    }

    public void buttoninit()
    {
        if (buttontag == "red2")
        {
            if(perkManager.red2unlock == true)
            {
                if (nextunlock)
                {
                    next.GetComponent<unlockerButtons>().unlockable = true;
                }
                Destroy(gameObject);
            }
        }
        else if (buttontag == "red3")
        {
            if (perkManager.red3unlock == true)
            {
                if (nextunlock)
                {
                    next.GetComponent<unlockerButtons>().unlockable = true;
                }
                Destroy(gameObject);
            }
        }
        else if (buttontag == "red4")
        {
            if (perkManager.red4unlock == true)
            {
                if (nextunlock)
                {
                    next.GetComponent<unlockerButtons>().unlockable = true;
                }
                Destroy(gameObject);
            }
        }
        else if (buttontag == "red5")
        {
            if (perkManager.red5unlock == true)
            {
                if (nextunlock)
                {
                    next.GetComponent<unlockerButtons>().unlockable = true;
                }
                Destroy(gameObject);
            }
        }

        if (buttontag == "blue2")
        {
            if (perkManager.blue2unlock == true)
            {
                if (nextunlock)
                {
                    next.GetComponent<unlockerButtons>().unlockable = true;
                }
                Destroy(gameObject);
            }
        }
        else if (buttontag == "blue3")
        {
            if (perkManager.blue3unlock == true)
            {
                if (nextunlock)
                {
                    next.GetComponent<unlockerButtons>().unlockable = true;
                }
                Destroy(gameObject);
            }
        }
        else if (buttontag == "blue4")
        {
            if (perkManager.blue4unlock == true)
            {
                if (nextunlock)
                {
                    next.GetComponent<unlockerButtons>().unlockable = true;
                }
                Destroy(gameObject);
            }
        }
        else if (buttontag == "blue5")
        {
            if (perkManager.blue5unlock == true)
            {
                if (nextunlock)
                {
                    next.GetComponent<unlockerButtons>().unlockable = true;
                }
                Destroy(gameObject);
            }
        }
    }
}
