using UnityEngine;
using System.Collections;

public class level4playerrotater : MonoBehaviour {

    public GameObject rotater;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("test1");
        if (other.gameObject.layer == (9))
        {
            Debug.Log("test");
            other.transform.parent = rotater.transform;

        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.CompareTag("player"))
       {
         other.transform.parent = null;
        }
    }
}
