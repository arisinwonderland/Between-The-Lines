using UnityEngine;
using System.Collections;

public class red5 : ability {
    
    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        Instantiate(attackObject, pos, Quaternion.identity);
    }
}
