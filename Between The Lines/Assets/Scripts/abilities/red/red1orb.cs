using UnityEngine;
using System.Collections;

public class red1orb : MonoBehaviour {

    public int damage;
    public bool abilityred;
    public float despawn;

    // Use this for initialization
    void Start () {

        damage = 15;
        despawn = 5;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * 30 * Time.deltaTime);

        despawn -= Time.deltaTime;
        if(despawn <= 0)
        {
            Destroy(gameObject);
        }
    }
}
