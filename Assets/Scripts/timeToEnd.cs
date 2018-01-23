using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeToEnd : MonoBehaviour {

	public float tiempoRestante = 30.0f;
	public GameObject ascensor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ascensor.transform.position.y >= 399) {
			tiempoRestante -= Time.deltaTime;

			if (tiempoRestante <= 0.0f)
				Application.LoadLevel (0);
		}
	}
}
