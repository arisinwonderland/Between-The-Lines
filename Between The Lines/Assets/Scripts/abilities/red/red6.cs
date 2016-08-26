using UnityEngine;
using System.Collections;

public class red6 : ability {

    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        Instantiate(attackObject, pos, angle);
    }
}
