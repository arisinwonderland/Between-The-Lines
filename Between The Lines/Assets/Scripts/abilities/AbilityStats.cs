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
        Debug.Log("test1");
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("test2");

            if (abilityRed == other.gameObject.GetComponent<enemy>().EnemyRed)
            {
                Debug.Log("test3");
                other.gameObject.GetComponent<enemy>().hp -=damage;

                //Red 5
                if(other.gameObject.GetComponent<enemy>().hp <= 0 && red5)
                {
                    red5unique();
                }

                //Red 7
                if (red7)
                {
                    Debug.Log("test4");
                    red7unique(other.gameObject);
                }

            }
        }

       
    }

    public void red5unique()
    {
        Instantiate(red5aoe, gameObject.transform.position, Quaternion.identity);
    }

    public void red7unique(GameObject other)
    {
        Debug.Log("test1");
        timer += Time.deltaTime;
        other.gameObject.GetComponent<enemy>().movespeed = 2;
        if(timer >= 100)
        {
            Debug.Log("test2");
            other.gameObject.GetComponent<enemy>().movespeed = 3;
            timer = 0;
        }else
        {
            red7unique(other);
        }
    }
}
