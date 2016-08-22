using UnityEngine;
using System.Collections;

public class bow : weapons
{

    public override void weaponStart(Vector3 pos, Quaternion angle)
    {
        Instantiate(attackObject, pos, angle);
    }

}