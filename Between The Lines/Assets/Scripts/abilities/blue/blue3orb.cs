using UnityEngine;
using System.Collections;

public class blue3orb : MonoBehaviour {

    public int damage;

    public GameObject player;
    public float despawn;

    // Use this for initialization
    void Start () {

        damage = 10;
        despawn = 2.4f;

        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = (new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
        transform.Rotate(0, 300 * Time.deltaTime, 0);

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            Destroy(gameObject);
        }
    }
}
