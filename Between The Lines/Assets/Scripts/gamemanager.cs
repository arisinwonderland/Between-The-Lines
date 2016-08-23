using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {

    //Current ability
    public string SelectedAbility;

    //Selected red abilities
    public string SelectedRedAbility1;
    public string SelectedRedAbility2;
    public string SelectedRedAbility3;

    //Selected blue abilities
    public string SelectedBlueAbility1;
    public string SelectedBlueAbility2;
    public string SelectedBlueAbility3;

    //Weapons
    public string SelectedWeapon;
    public string SelectedRedWeapon;
    public string SelectedBlueWeapon;

    //Passives
    public string SelectedPassive;

    //selected red passives
    public string SelectedRedPassive1;
    public string SelectedRedPassive2;
    public string SelectedRedPassive3;
    public string SelectedRedPassive4;
    public string SelectedRedPassive5;

    //selected blue passives
    public string SelectedBluePassive1;
    public string SelectedBluePassive2;
    public string SelectedBluePassive3;
    public string SelectedBluePassive4;
    public string SelectedBluePassive5;

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

    public void passiveselect(string selected)
    {
        SelectedPassive = selected;
    }

    public void SelectRedPassive1(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedPassive != "")
        {
            if (SelectedPassive != SelectedRedPassive1)
            {
                if (SelectedPassive != SelectedRedPassive2)
                {
                    if (SelectedPassive != SelectedRedPassive3)
                    {
                        if (SelectedPassive != SelectedRedPassive4)
                        {
                            if (SelectedPassive != SelectedRedPassive5)
                            {
                                Text txt = buttontext.GetComponentInChildren<Text>();
                                txt.text = SelectedPassive;
                                SelectedRedPassive1 = SelectedPassive;
                                SelectedPassive = "";
                                image.color = Color.white;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Empty";
            SelectedRedPassive1 = "";
            image.color = new Color(1F, 30 / 255F, 30 / 255F);
        }
    }

    public void SelectRedPassive2(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedPassive != "")
        {
            if (SelectedPassive != SelectedRedPassive1)
            {
                if (SelectedPassive != SelectedRedPassive2)
                {
                    if (SelectedPassive != SelectedRedPassive3)
                    {
                        if (SelectedPassive != SelectedRedPassive4)
                        {
                            if (SelectedPassive != SelectedRedPassive5)
                            {
                                Text txt = buttontext.GetComponentInChildren<Text>();
                                txt.text = SelectedPassive;
                                SelectedRedPassive2 = SelectedPassive;
                                SelectedPassive = "";
                                image.color = Color.white;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Empty";
            SelectedRedPassive2 = "";
            image.color = new Color(1F, 30 / 255F, 30 / 255F);
        }
    }

    public void SelectRedPassive3(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedPassive != "")
        {
            if (SelectedPassive != SelectedRedPassive1)
            {
                if (SelectedPassive != SelectedRedPassive2)
                {
                    if (SelectedPassive != SelectedRedPassive3)
                    {
                        if (SelectedPassive != SelectedRedPassive4)
                        {
                            if (SelectedPassive != SelectedRedPassive5)
                            {
                                Text txt = buttontext.GetComponentInChildren<Text>();
                                txt.text = SelectedPassive;
                                SelectedRedPassive3 = SelectedPassive;
                                SelectedPassive = "";
                                image.color = Color.white;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Empty";
            SelectedRedPassive3 = "";
            image.color = new Color(1F, 30 / 255F, 30 / 255F);
        }
    }

    public void SelectRedPassive4(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedPassive != "")
        {
            if (SelectedPassive != SelectedRedPassive1)
            {
                if (SelectedPassive != SelectedRedPassive2)
                {
                    if (SelectedPassive != SelectedRedPassive3)
                    {
                        if (SelectedPassive != SelectedRedPassive4)
                        {
                            if (SelectedPassive != SelectedRedPassive5)
                            {
                                Text txt = buttontext.GetComponentInChildren<Text>();
                                txt.text = SelectedPassive;
                                SelectedRedPassive4 = SelectedPassive;
                                SelectedPassive = "";
                                image.color = Color.white;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Empty";
            SelectedRedPassive4 = "";
            image.color = new Color(1F, 30 / 255F, 30 / 255F);
        }
    }

    public void SelectRedPassive5(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedPassive != "")
        {
            if (SelectedPassive != SelectedRedPassive1)
            {
                if (SelectedPassive != SelectedRedPassive2)
                {
                    if (SelectedPassive != SelectedRedPassive3)
                    {
                        if (SelectedPassive != SelectedRedPassive4)
                        {
                            if (SelectedPassive != SelectedRedPassive5)
                            {
                                Text txt = buttontext.GetComponentInChildren<Text>();
                                txt.text = SelectedPassive;
                                SelectedRedPassive5 = SelectedPassive;
                                SelectedPassive = "";
                                image.color = Color.white;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Empty";
            SelectedRedPassive5 = "";
            image.color = new Color(1F, 30 / 255F, 30 / 255F);
        }
    }

    public void SelectBluePassive1(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedPassive != "")
        {
            if (SelectedPassive != SelectedBluePassive1)
            {
                if (SelectedPassive != SelectedBluePassive2)
                {
                    if (SelectedPassive != SelectedBluePassive3)
                    {
                        if (SelectedPassive != SelectedBluePassive4)
                        {
                            if (SelectedPassive != SelectedBluePassive5)
                            {
                                Text txt = buttontext.GetComponentInChildren<Text>();
                                txt.text = SelectedPassive;
                                SelectedBluePassive1 = SelectedPassive;
                                SelectedPassive = "";
                                image.color = Color.white;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Empty";
            SelectedBluePassive1 = "";
            image.color = new Color(55F / 255F, 60F / 255F, 240F / 255F);
        }
    }

    public void SelectBluePassive2(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedPassive != "")
        {
            if (SelectedPassive != SelectedBluePassive1)
            {
                if (SelectedPassive != SelectedBluePassive2)
                {
                    if (SelectedPassive != SelectedBluePassive3)
                    {
                        if (SelectedPassive != SelectedBluePassive4)
                        {
                            if (SelectedPassive != SelectedBluePassive5)
                            {
                                Text txt = buttontext.GetComponentInChildren<Text>();
                                txt.text = SelectedPassive;
                                SelectedBluePassive2 = SelectedPassive;
                                SelectedPassive = "";
                                image.color = Color.white;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Empty";
            SelectedBluePassive2 = "";
            image.color = new Color(55F / 255F, 60F / 255F, 240F / 255F);
        }
    }

    public void SelectBluePassive3(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedPassive != "")
        {
            if (SelectedPassive != SelectedBluePassive1)
            {
                if (SelectedPassive != SelectedBluePassive2)
                {
                    if (SelectedPassive != SelectedBluePassive3)
                    {
                        if (SelectedPassive != SelectedBluePassive4)
                        {
                            if (SelectedPassive != SelectedBluePassive5)
                            {
                                Text txt = buttontext.GetComponentInChildren<Text>();
                                txt.text = SelectedPassive;
                                SelectedBluePassive3 = SelectedPassive;
                                SelectedPassive = "";
                                image.color = Color.white;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Empty";
            SelectedBluePassive3 = "";
            image.color = new Color(55F / 255F, 60F / 255F, 240F / 255F);
        }
    }

    public void SelectBluePassive4(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedPassive != "")
        {
            if (SelectedPassive != SelectedBluePassive1)
            {
                if (SelectedPassive != SelectedBluePassive2)
                {
                    if (SelectedPassive != SelectedBluePassive3)
                    {
                        if (SelectedPassive != SelectedBluePassive4)
                        {
                            if (SelectedPassive != SelectedBluePassive5)
                            {
                                Text txt = buttontext.GetComponentInChildren<Text>();
                                txt.text = SelectedPassive;
                                SelectedBluePassive4 = SelectedPassive;
                                SelectedPassive = "";
                                image.color = Color.white;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Empty";
            SelectedBluePassive4 = "";
            image.color = new Color(55F / 255F, 60F / 255F, 240F / 255F);
        }
    }

    public void SelectBluePassive5(GameObject buttontext)
    {
        Image image = buttontext.GetComponent<Image>();

        if (SelectedPassive != "")
        {
            if (SelectedPassive != SelectedBluePassive1)
            {
                if (SelectedPassive != SelectedBluePassive2)
                {
                    if (SelectedPassive != SelectedBluePassive3)
                    {
                        if (SelectedPassive != SelectedBluePassive4)
                        {
                            if (SelectedPassive != SelectedBluePassive5)
                            {
                                Text txt = buttontext.GetComponentInChildren<Text>();
                                txt.text = SelectedPassive;
                                SelectedBluePassive5 = SelectedPassive;
                                SelectedPassive = "";
                                image.color = Color.white;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            Text txt = buttontext.GetComponentInChildren<Text>();
            txt.text = "Empty";
            SelectedBluePassive5 = "";
            image.color = new Color(55F / 255F, 60F / 255F, 240F / 255F);
        }
    }

    public void loadlevel(int level)
    {
        
        SceneManager.LoadScene("testlevel");
        


    }

    public void loadmenu(string menu)
    {
        SelectedAbility = "";
        SelectedPassive = "";

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
