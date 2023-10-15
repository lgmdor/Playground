using UnityEngine;

public class KnifeAttack : MonoBehaviour {
	private KnifeStats stats;
	private DamageTaker target;

	public void Awake() {
		stats = GetComponent<KnifeStats>();
		target = GameObject.FindGameObjectWithTag("Samurai").GetComponent<DamageTaker>();

		//test
		InvokeRepeating("DealDamage", 0.1f, stats.FireRate.Current);
	}

	private void DealDamage() {
		target.TakeDamage(stats.Damage.Current);
	}
}
