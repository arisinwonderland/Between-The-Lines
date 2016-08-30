using UnityEngine;
using System.Collections;

public class red9 : ability
{

    public override void abilityStart(Vector3 pos, Quaternion angle)
    {
        playerscript.hp += playerscript.maxhp / 5 ;
        if(playerscript.hp > playerscript.maxhp)
        {
            playerscript.hp = playerscript.maxhp;
        }
    }
}