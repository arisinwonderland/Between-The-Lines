using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {

    public string selectedability;
    public string SelectedRedAbility1;
    public string SelectedRedAbility2;
    public string SelectedRedAbility3;


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
            if (selectedability != SelectedRedAbility2)
            {
                if (selectedability != SelectedRedAbility3)
                {
                    Text txt = buttontext.GetComponentInChildren<Text>();
                    txt.text = selectedability;
                    SelectedRedAbility1 = selectedability;
                    selectedability = "null";

                }
            }    
        }
    }

    public void select2(GameObject buttontext)
    {

        if (selectedability != "null")
        {
            if (selectedability != SelectedRedAbility1)
            {
                if (selectedability != SelectedRedAbility3)
                {
                    Text txt = buttontext.GetComponentInChildren<Text>();
                    txt.text = selectedability;
                    SelectedRedAbility2 = selectedability;
                    selectedability = "null";
                }
            }
        }
    }
    public void select3(GameObject buttontext)
    {
        if (selectedability != "null")
        {
            if (selectedability != SelectedRedAbility1)
            {
                if (selectedability != SelectedRedAbility2)
                {
                    Text txt = buttontext.GetComponentInChildren<Text>();
                    txt.text = selectedability;
                    SelectedRedAbility3 = selectedability;
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

    public void loadmenu(string menu)
    {
        if(menu == "blue")
        {
            DontDestroyOnLoad(transform.gameObject);
            SceneManager.LoadScene("bluemenu");
        }
    }

}
