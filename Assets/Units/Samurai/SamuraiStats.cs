using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiStats : UnitStats, IUnitBaseStats {
	[field: SerializeField] public override Stat Defense {get; protected set;} = new(0.1f);
	[field: SerializeField] public Stat BlockChance {get; protected set;} = new(0.02f);
}
