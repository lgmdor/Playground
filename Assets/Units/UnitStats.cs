using UnityEngine;

public abstract class UnitStats : MonoBehaviour, IUnitBaseStats {
	public virtual Stat HP {get; protected set;} = new(100);
	public virtual Stat Defense {get; protected set;} = new(0);
}
