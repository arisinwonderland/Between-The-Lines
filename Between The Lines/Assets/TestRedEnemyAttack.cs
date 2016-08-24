using UnityEngine;
using System.Collections;

public class TestRedEnemyAttack : MonoBehaviour {

    public float despawn;

    // Use this for initialization
    void Start () {
        despawn = 1;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * 15 * Time.deltaTime);
        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            Destroy(gameObject);
        }


    }
}
