using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AbilityButtonTextSetter : MonoBehaviour {

    public string color;
    public int num;

    public GameObject GameManager;
    public gamemanager gamemanager;

	// Use this for initialization
	void Start () {
		
		Image image = gameObject.GetComponent<Image>();
		Text txt = gameObject.GetComponentInChildren<Text>();
		string selectedText = ""; 

        gamemanager = GameManager.GetComponent<gamemanager>();

        if (color == "red")
        {
            switch (num)
            {
			case 1:
					
				selectedText = gamemanager.SelectedRedAbility1;

                break;

			case 2:
				
				selectedText = gamemanager.SelectedRedAbility2;

                break;

            case 3:

				selectedText = gamemanager.SelectedRedAbility3;

                break;

			case 4:

				selectedText = gamemanager.SelectedRedWeapon;

				break;
            }
        }
        else if (color == "blue")
        {
            switch (num)
            {
            case 1:

				selectedText = gamemanager.SelectedBlueAbility1;

                break;

            case 2:

				selectedText = gamemanager.SelectedBlueAbility2;

                break;

            case 3:

				selectedText = gamemanager.SelectedBlueAbility3;

                break;
			
			case 4:

				selectedText = gamemanager.SelectedBlueWeapon;

				break;
            }
        }
		if ((selectedText != "") && (num != 4)) {
			image.color = Color.white;
		} else if ((selectedText == "") && (num != 4)) {
			selectedText = "Empty";
		} else if ((selectedText == "") && (num == 4)) {
			if (color == "red") {
				selectedText = "Red Weapon";
			} else {
				selectedText = "Blue Weapon";
			}
		}
		Debug.Log (selectedText);
		txt.text = selectedText;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
