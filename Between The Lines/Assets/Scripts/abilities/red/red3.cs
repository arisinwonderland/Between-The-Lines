using UnityEngine;
using System.Collections;

public class red3 : ability {
    public GameObject dash;
    public GameObject dashyThing;
 
    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        Instantiate(attackObject, pos, angle);
        Instantiate(dash, pos, angle);
        Instantiate(dashyThing, pos, angle);
    }
}
