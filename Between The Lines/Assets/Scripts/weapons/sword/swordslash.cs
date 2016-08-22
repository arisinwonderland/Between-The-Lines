using UnityEngine;
using System.Collections;

public class swordslash : MonoBehaviour {

    public int damage;
    public GameObject player;
    public float despawn;

    // Use this for initialization
    void Start()
    {
        damage = 10;
        despawn = .5f;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.position = (new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            Destroy(gameObject);
        }

    }
}
