using UnityEngine;
using System.Collections;

public class red3dash : MonoBehaviour {

    public GameObject player;

    public int damage;

    public float despawn;

	// Use this for initialization
	void Start () {
        damage = 5;
        despawn = .4f;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * Time.deltaTime * 100);

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            Destroy(gameObject);
        }
    }
}
