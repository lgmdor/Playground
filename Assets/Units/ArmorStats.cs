using UnityEngine;

public class ArmorStats : MonoBehaviour, IUnitBaseStats {
	[field: SerializeField] public Stat HP {get; protected set;} = new(0);
	[field: SerializeField] public Stat Defense {get; protected set;} = new(0.3f);
}
