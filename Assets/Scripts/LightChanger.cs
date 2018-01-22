using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class LightChanger : MonoBehaviour {
	
	[SerializeField]
	private GameObject _light;
	[SerializeField]
	private float multiplier = 0.001f;
	private int contador = 0;

	// Use this for initialization
	void Start () {
		//_light = (GameObject) GameObject.FindObjectOfType<Light> ();
	}

	// Update is called once per frame
	void Update () {
		contador = contador + 1;
		Thread.Sleep (100);
		if (contador < 200) {
			_light.transform.Rotate(-Vector3.right * multiplier);
		}

	}
}
