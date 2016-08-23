using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class deathboxscript : MonoBehaviour {

    public int levelindex;
    public GameObject gamemanager;
    public gamemanager gamemanagerscript;
    

	// Use this for initialization
	void Start () {
        gamemanagerscript = gamemanager.GetComponent<gamemanager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gamemanagerscript.loadlevel(0);
        }
    }
}
