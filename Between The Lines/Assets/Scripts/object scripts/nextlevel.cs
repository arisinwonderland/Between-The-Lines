using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour {

    public int levelindex;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            switch (levelindex)
            {
                case 0:
                    SceneManager.LoadScene("Level 1");
                    break;

                case 1:
                    SceneManager.LoadScene("Level 2");
                    break;

                case 2:
                    SceneManager.LoadScene("Level 3");
                    break;

                default:
                    SceneManager.LoadScene("Level 1");
                    break;
            }

        }
    }
}
