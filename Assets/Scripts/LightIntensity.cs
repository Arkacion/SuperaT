using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour {
	
	[SerializeField]
	private Light _light;
	[SerializeField]
	private float multiplier = 0.1f;

	// Use this for initialization
	void Start () {
		//_light = (GameObject) GameObject.FindObjectOfType<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.N)) {
			_light.intensity = (_light.intensity >= 3f) ? 3f : _light.intensity + multiplier;
		}

		if (Input.GetKey (KeyCode.N)) {
			_light.intensity = (_light.intensity >= 3f) ? 3f : _light.intensity + multiplier;
		}


		if (Input.GetKeyDown (KeyCode.M)) {
			_light.intensity = (_light.intensity == 0f) ? 0f : _light.intensity - multiplier;
		}

		if (Input.GetKey (KeyCode.M)) {
			_light.intensity = (_light.intensity == 0f) ? 0f : _light.intensity - multiplier;
		}
	}
}
