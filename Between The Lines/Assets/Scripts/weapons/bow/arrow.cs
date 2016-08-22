using UnityEngine;
using System.Collections;

public class arrow : MonoBehaviour {

    public int damage;

    public float despawn;

    public GameObject Weapons;
    public bow bow;
    string current;

    // Use this for initialization
    void Start () {
        damage = 10;
        despawn = 5;
       
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * 65 * Time.deltaTime);

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            Destroy(gameObject);
        }

    }
}
