using UnityEngine;
using System.Collections;

public class WeaponStats : MonoBehaviour {

    public bool AttackRed;
    public int damage;
    public string WeaponClass;
    public GameObject player;
    public player playerscript;


    // Use this for initialization
    void Start() { 
        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();
        
	if(WeaponClass == "bow")
        {
        AttackRed = player.GetComponentInChildren<bow>().red;
        }

        if (WeaponClass == "sword")
        {
            AttackRed = player.GetComponentInChildren<sword>().red;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("test");
            if (AttackRed == other.gameObject.GetComponent<enemy>().EnemyRed)
            {
                other.gameObject.GetComponent<enemy>().hp -= damage;
            }
        }


    }
}
