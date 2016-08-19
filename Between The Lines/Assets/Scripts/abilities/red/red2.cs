using UnityEngine;
using System.Collections;

public class red2 : ability {

    
    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        Instantiate(attackObject, pos, Quaternion.identity);
    }
}
