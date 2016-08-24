using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

    public int hp;
    public bool EnemyRed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        //Weapons
        if (other.name == "ArrowSprite")
        {
            if (EnemyRed == other.gameObject.GetComponent<arrow>().bow.weaponred)
            {
                hp -= other.gameObject.GetComponent<arrow>().damage;
            }
        }
        if (other.name == "swordslash(Clone)")
        {
            if (EnemyRed == other.gameObject.GetComponent<swordslash>().sword.weaponred)
            {
                hp -= other.gameObject.GetComponent<swordslash>().damage;
            }
        }

        //Red abilities
        if (other.name == "red1orb(Clone)")
        {
            if (EnemyRed == other.gameObject.GetComponent<red1orb>().abilityred)
            {
                hp -= other.gameObject.GetComponent<red1orb>().damage;
            }
        }
        if (other.name == "red2aoe(Clone)")
        {
            if (EnemyRed == other.gameObject.GetComponent<red2aoe>().abilityred)
            {
                hp -= other.gameObject.GetComponent<red2aoe>().damage;
            }
        }
        if (other.name == "red3dash(Clone)")
        {
            if (EnemyRed == other.gameObject.GetComponent<red3dash>().abilityred)
            {
                hp -= other.gameObject.GetComponent<red3dash>().damage;
            }
        }
        if (other.name == "red4pillar(Clone)")
        {
            if (EnemyRed == other.gameObject.GetComponent<red4pillar>().abilityred)
            {
                hp -= other.gameObject.GetComponent<red4pillar>().damage;
            }
        }
        if (other.name == "red5aoe(Clone)")
        {
            if (EnemyRed == other.gameObject.GetComponent<red5aoe>().abilityred)
            {
                hp -= other.gameObject.GetComponent<red5aoe>().damage;
            }
        }

        //Blue abilities
        if (other.name == "blue1cone(Clone)")
        {
            if (EnemyRed == other.gameObject.GetComponent<blue1cone>().abilityred)
            {
                hp -= other.gameObject.GetComponent<blue1cone>().damage;
            }
        }
        if (other.name == "blue2dash(Clone)")
        {
            if (EnemyRed == other.gameObject.GetComponent<blue2dash>().abilityred)
            {
                hp -= other.gameObject.GetComponent<blue2dash>().damage;
            }
        }
        if (other.name == "blue3orbcollider")
        {
            if (EnemyRed == GameObject.Find("blue3orb(Clone)").GetComponent<blue3orb>().abilityred)
            {
                hp -= GameObject.Find("blue3orb(Clone)").GetComponent<blue3orb>().damage;
            }
        }
        if (other.name == "blue4beamcollider")
        {
            if (EnemyRed == GameObject.Find("blue4beam(Clone)").GetComponent<blue4beam>().abilityred)
            {
                hp -= GameObject.Find("blue4beam(Clone)").GetComponent<blue4beam>().damage;
            }
        }
        if (other.name == "blue5beamcollider")
        {
            if (EnemyRed == GameObject.Find("blue5beam(Clone)").GetComponent<blue5beam>().abilityred)
            {
                hp -= GameObject.Find("blue5beam(Clone)").GetComponent<blue5beam>().damage;
            }
        }

    }
}
