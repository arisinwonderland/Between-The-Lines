    using UnityEngine;
using System.Collections;

public class level2plate1 : MonoBehaviour {

    public GameObject gate;
    public GameObject gatetrigger;
    Vector3 pos;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("blueblock"))
        {
            gate.GetComponent<Collider>().enabled = false;
            gatetrigger.GetComponent<Collider>().enabled = false;
            gatetrigger.GetComponent<redField>().enabled = false;
            gatetrigger.GetComponent<Renderer>().enabled = false;
        }
        else {
            gate.GetComponent<Collider>().enabled = true;
            gatetrigger.GetComponent<Collider>().enabled = true;
            gatetrigger.GetComponent<redField>().enabled = true;
            gatetrigger.GetComponent<Renderer>().enabled = true;
        }
    }
}
