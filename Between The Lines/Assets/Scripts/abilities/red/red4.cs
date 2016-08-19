using UnityEngine;
using System.Collections;

public class red4 : ability {

    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        Instantiate(attackObject, pos + (Vector3.forward * 10), angle);
    }
}
