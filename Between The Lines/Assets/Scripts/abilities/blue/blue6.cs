using UnityEngine;
using System.Collections;

public class blue6 : ability {

	blue6shard attackScript;

    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
		attackObjs [uses-currentUses] = Instantiate (attackObject, pos, angle) as GameObject;
    }
	public override void abilityEnd (bool wasActivated) {
		for (int i = 0; i < uses - currentUses; i++) {
			attackScript = attackObjs [i].GetComponent<blue6shard>();
			attackScript.EndAbility (wasActivated);
			Debug.Log (i);
		}
	}
}
