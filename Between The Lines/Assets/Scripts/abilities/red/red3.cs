using UnityEngine;
using System.Collections;

public class red3 : ability {
    public GameObject dash;
    public GameObject dashyThing;
 
    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        Quaternion angyy = player.transform.rotation;
        angyy.Set(angyy.x, 90, angyy.z, angyy.w);
        angyy.SetEulerAngles(new Vector3(angyy.x, 90, angyy.z));
        Instantiate(attackObject, pos, angyy);
        Instantiate(dash, pos, angyy);
        Instantiate(dashyThing, pos, angyy);
    }
}
