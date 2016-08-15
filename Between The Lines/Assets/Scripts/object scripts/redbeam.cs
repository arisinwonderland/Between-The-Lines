using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class redbeam : MonoBehaviour {

    public int levelindex;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            switch (levelindex)
            {
                case 0:
                    SceneManager.LoadScene("Level 0");
                    break;

                case 1:
                    SceneManager.LoadScene("Level 1");
                    break;

                case 2:
                    SceneManager.LoadScene("Level 2");
                    break;
                case 3:
                    SceneManager.LoadScene("Level 3");
                    break;
                case 4:
                    SceneManager.LoadScene("Level 4");
                    break;
                case 5:
                    SceneManager.LoadScene("Level 5");
                    break;
                case 6:
                    SceneManager.LoadScene("Level 6");
                    break;

                default:
                    SceneManager.LoadScene("Level 0");
                    break;
            }

        }
    }
}
