using UnityEngine;
using System.Collections;

public class blue7 : ability {

    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        Quaternion angyy = player.transform.rotation;
        angyy.Set(angyy.x, 90, angyy.z, angyy.w);
        angyy.SetEulerAngles(new Vector3(angyy.x, 90, angyy.z));
		attackObjs[0] = Instantiate (attackObject, pos, angyy) as GameObject;
    }

	public override void abilityEnd(bool wasActivated) {
		attackObjs[0].GetComponent<blue7dash>().EndAbility (wasActivated);
	}
}
