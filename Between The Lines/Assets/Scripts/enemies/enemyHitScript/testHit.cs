using UnityEngine;
using System.Collections;

public class testHit : baseAttack {


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hoop");
        if (other.gameObject.name == "Player")
        {
            Debug.Log("player");
            if (other.gameObject.GetComponent<player>().red == redAttack)
            {
                other.gameObject.GetComponent<player>().hp -= damage;
                Destroy(gameObject);
            }
        }

    }

}
