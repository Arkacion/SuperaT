using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeToEndScenes : MonoBehaviour {
	
	public float tiempoRestante = 30.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		tiempoRestante -= Time.deltaTime;

		if (tiempoRestante <= 0.0f)
			Application.LoadLevel (0);
		
	}
}
