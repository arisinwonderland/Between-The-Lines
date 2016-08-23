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

    public string SelectedWeapon;
    public string SelectedRedWeapon;
    public string SelectedBlueWeapon;


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void abilityselect(string selected)
    {
		/*if (SelectedAbility == selected) {
			SelectedAbility = "";
		} else {*/
			SelectedAbility = selected;
		//}
    }

    public void SelectRed1(GameObject buttontext)
    {       
		Image image = buttontext.GetComponent<Image>();

		if (SelectedAbility != "") {
			if (SelectedAbility != SelectedRedAbility1) {
				if (SelectedAbility != SelectedRedAbility2) {
					if (SelectedAbility != SelectedRedAbility3) {
						Text txt = buttontext.GetComponentInChildren<Text> ();
						txt.text = SelectedAbility;
						SelectedRedAbility1 = SelectedAbility;
						SelectedAbility = "";
						image.color = Color.white;
					}
				}
			}    
		} else {
			Text txt = buttontext.GetComponentInChildren<Text> ();
			txt.text = "Empty";
			SelectedRedAbility1 = "";
			image.color = new Color(1F, 30/255F, 30/255F);
		}
    }

    public void SelectRed2(GameObject buttontext)
	{
		Image image = buttontext.GetComponent<Image>();

        if (SelectedAbility != "")
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
						SelectedAbility = "";
						image.color = Color.white;
                    }
                }
            }
		} else {
			Text txt = buttontext.GetComponentInChildren<Text> ();
			txt.text = "Empty";
			SelectedRedAbility2 = "";
			image.color = new Color(1F, 30/255F, 30/255F);
		}
    }

    public void SelectRed3(GameObject buttontext)
	{
		Image image = buttontext.GetComponent<Image>();

        if (SelectedAbility != "")
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
						SelectedAbility = "";
						image.color = Color.white;
                    }
                }
            }
		} else {
			Text txt = buttontext.GetComponentInChildren<Text> ();
			txt.text = "Empty";
			SelectedRedAbility3 = "";
			image.color = new Color(1F, 30/255F, 30/255F);
		}
    }

    public void SelectBlue1(GameObject buttontext)
	{
		Image image = buttontext.GetComponent<Image>();

        if (SelectedAbility != "")
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
						SelectedAbility = "";
						image.color = Color.white;
                    }
                }
            }
		} else {
			Text txt = buttontext.GetComponentInChildren<Text> ();
			txt.text = "Empty";
			SelectedBlueAbility1 = "";
			image.color = new Color(55F/255F, 60F/255F, 240F/255F);
		}
    }

    public void SelectBlue2(GameObject buttontext)
	{
		Image image = buttontext.GetComponent<Image>();

        if (SelectedAbility != "")
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
						SelectedAbility = "";
						image.color = Color.white;
                    }
                }
            }
		} else {
			Text txt = buttontext.GetComponentInChildren<Text> ();
			txt.text = "Empty";
			SelectedBlueAbility2 = "";
			image.color = new Color(55F/255F, 60F/255F, 240F/255F);
		}

    }

    public void SelectBlue3(GameObject buttontext)
	{
		Image image = buttontext.GetComponent<Image>();
     
        if (SelectedAbility != "")
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
						SelectedAbility = "";
						image.color = Color.white;
                    }
                }
            }
		} else {
			Text txt = buttontext.GetComponentInChildren<Text> ();
			txt.text = "Empty";
			SelectedBlueAbility3 = "";
			image.color = new Color(55F/255F, 60F/255F, 240F/255F);
		}
    }

    public void weaponselect(string selected)
    {
		/*if (SelectedWeapon == selected) {
			SelectedWeapon = "";
		} else { */
			SelectedWeapon = selected;
		//}
    }

    public void SelectRedWeapon(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedWeapon != "")
        {
            if (SelectedWeapon != SelectedRedWeapon)
            {
                if (SelectedWeapon != SelectedBlueWeapon)
                {
                        Text txt = buttontext.GetComponentInChildren<Text>();
                        txt.text = SelectedWeapon;
                        SelectedRedWeapon = SelectedWeapon;
                        SelectedWeapon = "";
                        //image.color = Color.white;
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Red Weapon";
            SelectedRedWeapon = "";
            //image.color = new Color(1F, 30/255F, 30/255F);
        }
    }

    public void SelectBlueWeapon(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedWeapon != "")
        {
            if (SelectedWeapon != SelectedRedWeapon)
            {
                if (SelectedWeapon != SelectedBlueWeapon)
                {
                    Text txt = buttontext.GetComponentInChildren<Text>();
                    txt.text = SelectedWeapon;
                    SelectedBlueWeapon = SelectedWeapon;
                    SelectedWeapon = "";
                    //image.color = Color.white;
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Blue Weapon";
			SelectedBlueWeapon = "";
			//image.color = new Color(55F/255F, 60F/255F, 240F/255F);
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
			SelectedAbility = "";
            SceneManager.LoadScene("bluemenu");
        }

        if(menu == "red")
        {

			SelectedAbility = "";
            SceneManager.LoadScene("redmenu");
        }

		if(menu == "items")
		{

			SelectedAbility = "";
			SceneManager.LoadScene("itemsmenu");
		}
    }

}
