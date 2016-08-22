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
            }
        }
        if (color == "blue")
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

            }
        }
		if (selectedText != "") {
			image.color = Color.white;
		}
		Debug.Log (selectedText);
		txt.text = selectedText;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
