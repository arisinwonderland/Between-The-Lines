    using UnityEngine;
using System.Collections;

public class level2plate1 : MonoBehaviour {

    public GameObject gate;
    Vector3 pos;

    // Use this for initialization
    void Start () {
        Vector3 pos = new Vector3(gate.transform.position.x, gate.transform.position.y, gate.transform.position.z);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("blueblock"))
        {
            gate.transform.position = new Vector3(1000, 1000, 1000);
        }else {
            
            gate.transform.position = new Vector3(pos.x,pos.y,pos.z);
        }
    }
}
