using UnityEngine;
using System.Collections;

public class arrow : MonoBehaviour {

    public int damage;
    public float despawn;
    public player playerscript;
    public GameObject player;
    public bow bow;

    // Use this for initialization
    void Start () {
        damage = 10;
        despawn = 5;

        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();
        bow = player.GetComponentInChildren<bow>();

        if (bow.weaponred == true)
        {
            gameObject.layer = 18;
        }else if(bow.weaponred == false)
        {
            gameObject.layer = 19;
        }

	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.right * 65 * Time.deltaTime);

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            Destroy(gameObject);
        }

    }

}
