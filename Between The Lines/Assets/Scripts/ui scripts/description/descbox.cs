using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class descbox : MonoBehaviour {

	public GameObject GameManager;
	public gamemanager gamemanager;

	public string currentDesc = "Cone Of Cold";
	public bool hidden = false;

	Image image;
	Text txt;
	Vector3 pos;
	Dictionary<string, string> descriptions = new Dictionary<string, string>();

	// Use this for initialization
	void Start () {
		image = gameObject.GetComponent<Image>();
		txt = gameObject.GetComponentInChildren<Text>();

		descriptions.Add ("Prism", "<b><color=blue>Prism</color></b>\nActive\nCone damage");
		descriptions.Add ("Soaring Hope", "<b><color=blue>Soaring Hope</color></b>\nActive\nDash up");
		descriptions.Add ("Guardian Blade", "<b><color=blue>Guardian Blade</color></b>\nActive\nA blade orbits you");
		descriptions.Add ("Heavenly Wrath", "<b><color=blue>Heavenly Wrath</color></b>\nALong ranged beam damages enemies in its path");
		descriptions.Add ("Halo\'s Reach", "<b><color=blue>Halo\'s Reach</color></b>\nActive\nBeams rotate around you while you are rooted in place");
        descriptions.Add("Shards of Eternity", "<b><color=blue>Halo\'s Reach</color></b>\nActive\nPlace three shards that deal damage and can be moved to you");
        descriptions.Add("Celestial Shift", "<b><color=blue>Halo\'s Reach</color></b>\nActive\nMark the ground and dash forward, reactivate to dash to the mark");
        descriptions.Add("Soul Tap", "<b><color=blue>Halo\'s Reach</color></b>\nActive\nDrain an enemies HP");
        descriptions.Add("Lightning Shock", "<b><color=blue>Halo\'s Reach</color></b>\nActive\nChain lightning");

        descriptions.Add ("Firebolt", "<b><color=red>Firebolt</color></b>\nActive\nFire a projectile which does damage to enemies it strikes");
		descriptions.Add ("Obsidian Rush", "<b><color=red>Obsidian Rush</color></b>\nActive\nEnemies close to you take damage");
		descriptions.Add ("Surge of Flame", "<b><color=red>Surge of Flame</color></b>\nActive\nDash forward, dealing damage to enemies you pass through");
		descriptions.Add ("Demonic Pillar", "<b><color=red>Demonic Pillar</color></b>\nActive\nSummon a pillar which does damage");
		descriptions.Add ("Cataclysm", "<b><color=red>Cataclysm</color></b>\nActive\nDeal damage to enemies. If this kills an enemy they will explode");
        descriptions.Add("Ritual Summon", "<b><color=red>Ritual Summon</color></b>\nActive\nDrop a sigil which explodes shortly, dealing damage to enemies above it");
        descriptions.Add("Brimstone Blast", "<b><color=red>Brimstone Blast</color></b>\nActive\nFire a projectile which explodes early on enemy contact");
        descriptions.Add("Pillar Chain", "<b><color=red>Pillar Chain</color></b>\nActive\nPillars move to the left and right of you, dealing damage");
        descriptions.Add("Dark Gift", "<b><color=red>Dark Gift</color></b>\nActive\nHeal 20 percent of your max HP");

        descriptions.Add("Start", "<b><color=blue>Up Close</color></b>\nPassive\nDescription here");

        descriptions.Add ("Up Close Blue", "<b><color=blue>Up Close</color></b>\nPassive\nDescription here");
		descriptions.Add ("Far Away Blue", "<b><color=blue>Far Away</color></b>\nPassive\nDescription here");
		descriptions.Add ("Cold Hearted", "<b><color=blue>Cold Hearted</color></b>\nPassive\nDescription here");
		descriptions.Add ("Freeze", "<b><color=blue>Freeze</color></b>\nPassive\nDescription here");
		descriptions.Add ("Mana Drain", "<b><color=blue>Mana Drain</color></b>\nPassive\nDescription here");

		descriptions.Add ("Up Close Red", "<b><color=red>Up Close</color></b>\nPassive\nDescription here");
		descriptions.Add ("Far Away Red", "<b><color=red>Far Away</color></b>\nPassive\nDescription here");
		descriptions.Add ("Mana Regen", "<b><color=red>Mana Regen</color></b>\nPassive\nDescription here");
		descriptions.Add ("Lifesteal", "<b><color=red>Lifesteal</color></b>\nPassive\nDescription here");
		descriptions.Add ("Slow Burn", "<b><color=red>Slow Burn</color></b>\nPassive\nDescription here");
	}

	void Update () {
		if (hidden) {
			image.enabled = false;
			txt.enabled = false;
		} else {
			image.enabled = true;
			txt.enabled = true;
			pos = Input.mousePosition;
			pos.z = 10F;
			pos = Camera.main.ScreenToWorldPoint(pos);
			transform.position = pos;
			txt.text = descriptions [currentDesc];
		}
	}
}
