using UnityEngine;
using System.Collections;

public class enemyDamage : MonoBehaviour {

    public int hp;
    public bool EnemyRed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        //death
        if(hp < 0)
        {
            Destroy(gameObject);
        }




	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ability"))
        {
            if (EnemyRed == other.gameObject.GetComponent<AbilityStats>().abilityRed)
            {
                hp -= other.gameObject.GetComponent<AbilityStats>().damage;
            }
        }

        if (other.CompareTag("attack"))
        {
            if(EnemyRed == other.gameObject.GetComponent<WeaponStats>().AttackRed)
            {
                hp -= other.gameObject.GetComponent<WeaponStats>().damage;
            }


        }
    }
}
