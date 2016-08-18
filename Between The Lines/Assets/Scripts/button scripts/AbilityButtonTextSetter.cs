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

        Text txt = gameObject.GetComponentInChildren<Text>();

        gamemanager = GameManager.GetComponent<gamemanager>();

        if (color == "red")
        {
            switch (num)
            {
                case 1:

                    txt.text = gamemanager.SelectedRedAbility1;

                    break;

                case 2:

                    txt.text = gamemanager.SelectedRedAbility2;

                    break;

                case 3:

                    txt.text = gamemanager.SelectedRedAbility3;

                    break;
            }
        }
            if (color == "blue")
            {
                switch (num)
                {
                    case 1:

                        txt.text = gamemanager.SelectedBlueAbility1;

                        break;

                    case 2:

                        txt.text = gamemanager.SelectedBlueAbility2;

                        break;

                    case 3:

                        txt.text = gamemanager.SelectedBlueAbility3;

                        break;

                }
            }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
