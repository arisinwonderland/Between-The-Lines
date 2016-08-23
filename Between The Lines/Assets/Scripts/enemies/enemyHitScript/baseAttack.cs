using UnityEngine;
using System.Collections;

public class baseAttack : MonoBehaviour {


    public float tillDespawn;
    public float timer;
    public int damage;






	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        tillDespawn--;
        if (tillDespawn <= 0)
        {
            Destroy(gameObject);
        }
	}
}
