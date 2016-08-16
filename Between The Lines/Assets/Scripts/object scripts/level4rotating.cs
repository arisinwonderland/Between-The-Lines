using UnityEngine;
using System.Collections;

public class level4rotating : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(0, 5 * Time.deltaTime, 0);
	}
}
