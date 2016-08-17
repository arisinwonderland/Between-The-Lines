using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {

    public string selectedability;
    public string selectedability1;
    public string selectedability2;
    public string selectedability3;


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void abilityselect(string selected)
    {
        selectedability = selected;
    }

    public void select1(GameObject buttontext)
    {       
        if(selectedability != "null")
        {
            if (selectedability != selectedability2)
            {
                if (selectedability != selectedability3)
                {
                    Text txt = buttontext.GetComponentInChildren<Text>();
                    txt.text = selectedability;
                    selectedability1 = selectedability;
                    selectedability = "null";

                }
            }    
        }
    }

    public void select2(GameObject buttontext)
    {

        if (selectedability != "null")
        {
            if (selectedability != selectedability1)
            {
                if (selectedability != selectedability3)
                {
                    Text txt = buttontext.GetComponentInChildren<Text>();
                    txt.text = selectedability;
                    selectedability2 = selectedability;
                    selectedability = "null";
                }
            }
        }
    }
    public void select3(GameObject buttontext)
    {
        if (selectedability != "null")
        {
            if (selectedability != selectedability1)
            {
                if (selectedability != selectedability2)
                {
                    Text txt = buttontext.GetComponentInChildren<Text>();
                    txt.text = selectedability;
                    selectedability3 = selectedability;
                    selectedability = "null";
                }
            }
        }
    }

    public void loadlevel(int level)
    {
        DontDestroyOnLoad(transform.gameObject);
        SceneManager.LoadScene("testlevel");


    }

}
