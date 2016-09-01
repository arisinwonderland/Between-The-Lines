using UnityEngine;
using System.Collections;

public class RedEyeAttack : MonoBehaviour {

    public GameObject leftAttack;
    public GameObject rightAttack;

    public float timer;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if(timer >= .25f)
        {
            Destroy(gameObject);
        }

        leftAttack.transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        rightAttack.transform.Translate(Vector3.back *10 * Time.deltaTime);

    }
}
