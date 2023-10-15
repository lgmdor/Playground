using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

[RequireComponent(typeof(UnitStats))]

public class EquipmentInventory : MonoBehaviour {
	[SerializeField] private List<IUnitBaseStats> equipment;
	[SerializeField] private GameObject armorPrefab; //test

	private UnitStats stats;

	public void Awake() {
		stats = GetComponent<UnitStats>();
		equipment = new List<IUnitBaseStats>();

		Invoke("AddArmor", 2);
	}

	//test
	private void AddArmor() {
		GameObject armor = Instantiate(armorPrefab);

		AddEquipment(armor.GetComponent<ArmorStats>());
	}

	public void AddEquipment(IUnitBaseStats newEquipment) {
		equipment.Add(newEquipment);

		stats.HP.AddModifier(newEquipment.HP.Current);
		stats.Defense.AddModifier(newEquipment.Defense.Current);

		Debug.Log($"equipped item with {newEquipment.Defense.Current} defense");
		Debug.Log($"samurai defense is now {stats.Defense.Current}");
	}

}
