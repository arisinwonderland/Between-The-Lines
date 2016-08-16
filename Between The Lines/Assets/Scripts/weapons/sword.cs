using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour {

    public GameObject holder;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position.Set(holder.transform.position.x, holder.transform.position.y, holder.transform.position.z);
        transform.rotation.Set(holder.transform.rotation.x, holder.transform.rotation.y, holder.transform.rotation.z, holder.transform.rotation.w);
	}
}
