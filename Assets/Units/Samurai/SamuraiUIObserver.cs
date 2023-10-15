using UnityEngine;
using UnityEngine.UI;

public class SamuraiUIObserver : MonoBehaviour {
	[SerializeField] private GameObject samurai;

	public void Awake() {
		samurai.GetComponent<UnitStats>().HP.changed += ((float x, float y) payload) => {
			Debug.Log("loool");
		};
		// Debug.Log(samurai.GetComponent<UnitStats>().HP.Current);
	}

	private void UpdateTextHP((float difference, float newStat) payload) {
		Debug.Log("updateTextHP");
		gameObject.GetComponent<Text>().text = payload.newStat.ToString();
	}
}
