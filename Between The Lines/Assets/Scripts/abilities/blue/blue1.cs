using UnityEngine;
using System.Collections;

public class blue1 : ability {

    public GameObject player;

    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        Vector3 positrons = player.transform.position;
        positrons.z += 2.5f;
        Quaternion angyy = angle;
        //angyy.y = player.transform.eulerAngles.y;
        Instantiate(attackObject, positrons, angyy);
    }
}
