using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class LightChanger : MonoBehaviour {
	
	[SerializeField]
	private GameObject _light;
	[SerializeField]
	private float multiplier = 0.001f;

	// Use this for initialization
	void Start () {
		//_light = (GameObject) GameObject.FindObjectOfType<Light> ();
	}

	// Update is called once per frame
	void Update () {
		Thread.Sleep(50);
		_light.transform.Rotate(-Vector3.right * multiplier);
	}
}
