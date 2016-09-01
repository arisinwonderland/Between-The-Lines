using UnityEngine;
using System.Collections;

public class blue8 : ability {

	public override void abilityStart(Vector3 pos, Quaternion angle)
	{
		attackObjs[0] = Instantiate (attackObject, pos, angle) as GameObject;
	}

	public override void abilityEnd(bool wasActivated) {
		attackObjs[0].GetComponent<blue8drain>().EndAbility (wasActivated);
	}
}
