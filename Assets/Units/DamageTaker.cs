using UnityEngine;

[RequireComponent(typeof(UnitStats))]

public class DamageTaker : MonoBehaviour {
	private UnitStats stats;

	public void Awake() {
		stats = GetComponent<UnitStats>();
	}

	public bool TakeDamage(float rawDamage) {
		float finalDamage = rawDamage * (1 - stats.Defense.Current);

		stats.HP.Current -= finalDamage;

		Debug.Log($"took {finalDamage} damage");
		Debug.Log($"samurai has {stats.HP.Current} HP");

		return stats.HP.Current <= 0 ? true : false;
	}
}
