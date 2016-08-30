    using UnityEngine;
using System.Collections;

public class AbilityStats : MonoBehaviour {

    public bool abilityRed;
    public int damage;

    public bool red5;
    public GameObject red5aoe;

    public bool red7;

    public float timer;
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

                //Red 5
                if(other.gameObject.GetComponent<enemy>().hp <= 0 && red5)
                {
                    red5unique();
                }
    

            }
        }

       
    }

    public void red5unique()
    {
        Instantiate(red5aoe, gameObject.transform.position, Quaternion.identity);
    }


}
