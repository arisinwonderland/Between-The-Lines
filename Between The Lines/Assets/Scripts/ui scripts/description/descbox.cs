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

		descriptions.Add ("Prism", "<b><color=blue>Prism</color></b>\nActive\nDescription here");
		descriptions.Add ("Soaring Hope", "<b><color=blue>Soaring Hope</color></b>\nActive\nDescription here");
		descriptions.Add ("Guardian Blade", "<b><color=blue>Guardian Blade</color></b>\nActive\nDescription here");
		descriptions.Add ("Heavenly Wrath", "<b><color=blue>Heavenly Wrath</color></b>\nActive\nDescription here");
		descriptions.Add ("Halo\'s Reach", "<b><color=blue>Halo\'s Reach</color></b>\nActive\nDescription here");

		descriptions.Add ("Firebolt", "<b><color=red>Firebolt</color></b>\nActive\nDescription here");
		descriptions.Add ("Obsidian Rush", "<b><color=red>Obsidian Rush</color></b>\nActive\nDescription here");
		descriptions.Add ("Surge of Flame", "<b><color=red>Surge of Flame</color></b>\nActive\nDescription here");
		descriptions.Add ("Demonic Pillar", "<b><color=red>Demonic Pillar</color></b>\nActive\nDescription here");
		descriptions.Add ("Cataclysm", "<b><color=red>Cataclysm</color></b>\nActive\nDescription here");

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
