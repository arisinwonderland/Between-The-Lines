using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {

    public string SelectedAbility;
    public string SelectedRedAbility1;
    public string SelectedRedAbility2;
    public string SelectedRedAbility3;
    public string SelectedBlueAbility1;
    public string SelectedBlueAbility2;
    public string SelectedBlueAbility3;


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void abilityselect(string selected)
    {
        SelectedAbility = selected;
    }

    public void SelectRed1(GameObject buttontext)
    {       
        if(SelectedAbility != "null")
        {
            if (SelectedAbility != SelectedRedAbility1)
            {
                if (SelectedAbility != SelectedRedAbility2)
                {
                    if (SelectedAbility != SelectedRedAbility3)
                    {
                        Text txt = buttontext.GetComponentInChildren<Text>();
                        txt.text = SelectedAbility;
                        SelectedRedAbility1 = SelectedAbility;
                        SelectedAbility = "null";

                    }
                }
            }    
        }
    }

    public void SelectRed2(GameObject buttontext)
    {

        if (SelectedAbility != "null")
        {
            if (SelectedAbility != SelectedRedAbility1)
            {
                if (SelectedAbility != SelectedRedAbility2)
                {
                    if (SelectedAbility != SelectedRedAbility3)
                    {
                        Text txt = buttontext.GetComponentInChildren<Text>();
                        txt.text = SelectedAbility;
                        SelectedRedAbility2 = SelectedAbility;
                        SelectedAbility = "null";
                    }
                }
            }
        }
    }
    public void SelectRed3(GameObject buttontext)
    {
        if (SelectedAbility != "null")
        {
            if (SelectedAbility != SelectedRedAbility1)
            {
                if (SelectedAbility != SelectedRedAbility2)
                {
                    if (SelectedAbility != SelectedRedAbility3)
                    {
                        Text txt = buttontext.GetComponentInChildren<Text>();
                        txt.text = SelectedAbility;
                        SelectedRedAbility3 = SelectedAbility;
                        SelectedAbility = "null";
                    }
                }
            }
        }
    }

    public void SelectBlue1(GameObject buttontext)
    {
        if (SelectedAbility != "null")
        {
            if (SelectedAbility != SelectedBlueAbility1)
            {
                if (SelectedAbility != SelectedBlueAbility2)
                {
                    if (SelectedAbility != SelectedBlueAbility3)
                    {
                        Text txt = buttontext.GetComponentInChildren<Text>();
                        txt.text = SelectedAbility;
                        SelectedBlueAbility1 = SelectedAbility;
                        SelectedAbility = "null";
                    }
                }
            }
        }
    }

    public void SelectBlue2(GameObject buttontext)
    {
        if (SelectedAbility != "null")
        {
            if (SelectedAbility != SelectedBlueAbility1)
            {
                if (SelectedAbility != SelectedBlueAbility2)
                {
                    if (SelectedAbility != SelectedBlueAbility3)
                    {
                        Text txt = buttontext.GetComponentInChildren<Text>();
                        txt.text = SelectedAbility;
                        SelectedBlueAbility2 = SelectedAbility;
                        SelectedAbility = "null";
                    }
                }
            }
        }

    }

    public void SelectBlue3(GameObject buttontext)
    {
     
        if (SelectedAbility != "null")
        {
            if (SelectedAbility != SelectedBlueAbility1)
            {
                if (SelectedAbility != SelectedBlueAbility2)
                {
                    if (SelectedAbility != SelectedBlueAbility3)
                    {
                        Text txt = buttontext.GetComponentInChildren<Text>();
                        txt.text = SelectedAbility;
                        SelectedBlueAbility3 = SelectedAbility;
                        
                        SelectedAbility = "null";
                    }
                }
            }
        }
    }

    public void loadlevel(int level)
    {
        
        SceneManager.LoadScene("testlevel");
        


    }

    public void loadmenu(string menu)
    {
        if(menu == "blue")
        {
      
            SceneManager.LoadScene("bluemenu");
        }

        if(menu == "red")
        {
            
            SceneManager.LoadScene("redmenu");
        }
    }

}
