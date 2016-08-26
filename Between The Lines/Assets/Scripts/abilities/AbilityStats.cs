using UnityEngine;
using System.Collections;

public class AbilityStats : MonoBehaviour {

    public bool abilityRed;
    public int damage;

    public bool red5;
    public GameObject red5aoe;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
 
            if (abilityRed == other.gameObject.GetComponent<enemy>().EnemyRed)
            {
                other.gameObject.GetComponent<enemy>().hp -=damage;
                if(other.gameObject.GetComponent<enemy>().hp <= 0)
                {
                    Instantiate(red5aoe, gameObject.transform.position, Quaternion.identity);
                }
            }
        }

       
    }
}
