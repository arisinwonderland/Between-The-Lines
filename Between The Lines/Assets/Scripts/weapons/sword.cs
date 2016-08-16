using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour {

    public GameObject holder;

	// Use this for initialization
	void Start () {
        
        gameObject.transform.parent = holder.transform;
        transform.position = holder.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
