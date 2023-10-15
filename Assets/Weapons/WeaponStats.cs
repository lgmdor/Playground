using UnityEngine;

public class WeaponStats : MonoBehaviour {
	[field: SerializeField] public Stat Damage {get; protected set;} = new(10);
	[field: SerializeField] public Stat FireRate {get; protected set;} = new(1);
}
