using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;

[Serializable]
public class Stat {
	public event Action<(float, float)> changed;

	[SerializeField] private float _current;

	[field: SerializeField] public float Default {get; private set;}
	[field: SerializeField] public List<float> Modifiers {get; private set;}

	public float Current {
		get {
			return Modifiers.Aggregate(_current, (acc, curr) => acc + curr);
		}
		set {
			float difference = _current - value;

			_current = value;

			changed?.Invoke((difference, _current));
		}
	}

	public Stat(float default_) {
		Default = default_;
		Current = Default;
		Modifiers = new List<float>();
	}

	public void Reset() {
		Current = Default;
		Modifiers.Clear();
	}

	public void AddModifier(float modifier) {
		Modifiers.Add(modifier);
	}

	public void RemoveModifier(float modifier) {
		Modifiers.Remove(modifier);
	}
}