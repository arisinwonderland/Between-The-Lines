using UnityEngine;
using System.Collections;

public class arrow : MonoBehaviour {

    public int damage;

    public float despawn;

	// Use this for initialization
	void Start () {
        damage = 10;
        despawn = 5;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * 75 * Time.deltaTime);

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            Destroy(gameObject);
        }

    }
}
