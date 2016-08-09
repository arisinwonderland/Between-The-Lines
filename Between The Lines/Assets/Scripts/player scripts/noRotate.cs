using UnityEngine;
using System.Collections;

public class noRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
