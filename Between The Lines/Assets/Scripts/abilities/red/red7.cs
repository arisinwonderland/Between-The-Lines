using UnityEngine;
using System.Collections;

public class red7 : ability {

    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        Instantiate(attackObject, pos, angle);
    }
}
