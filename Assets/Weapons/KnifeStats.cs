using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeStats : WeaponStats {
	[field: SerializeField] public Stat BleedChance {get; protected set;} = new(0.02f);
}
