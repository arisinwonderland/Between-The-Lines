using UnityEngine;
using System.Collections;

public class red8 : ability
{

    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        Instantiate(attackObject, pos, angle);
    }
}