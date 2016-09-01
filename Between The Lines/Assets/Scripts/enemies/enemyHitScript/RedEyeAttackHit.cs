using UnityEngine;
using System.Collections;

public class RedEyeAttackHit : baseAttack{

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player")
        {

            if (other.gameObject.GetComponent<player>().red == redAttack)
            {
                other.gameObject.GetComponent<player>().hp -= damage;
             
            }
        }

    }

}
