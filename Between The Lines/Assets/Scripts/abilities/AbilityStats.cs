using UnityEngine;
using System.Collections;

public class AbilityStats : MonoBehaviour {

    public bool abilityRed;
    public int damage;

    public bool red5;
    public GameObject red5aoe;

	public bool blue8;
	public GameObject blue8obj;
	public blue8drain blue8script;

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

				if (other.gameObject.GetComponent<enemy>().hp > 0 && blue8) {
					blue8unique(other.gameObject);
				}            
			}
        }

       
    }

    public void red5unique()
    {
        Instantiate(red5aoe, gameObject.transform.position, Quaternion.identity);
    }

	public void blue8unique(GameObject enemy) {
		blue8script = gameObject.transform.parent.gameObject.GetComponent<blue8drain> ();
		blue8script.startDrain (enemy);
	}

}
