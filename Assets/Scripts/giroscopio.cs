using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giroscopio : MonoBehaviour {

	public GameObject VRCamaras;

	private float posicionInicialY = 0f;
	private float posicionGiroY = 0f;
	private float calibrarPosicionY = 0f;

	public bool juegoIniciado;

	void Start () {
		Input.gyro.enabled = true;
		posicionInicialY = VRCamaras.transform.eulerAngles.y;
	}
	
	// Update is called once per frame
	void Update () {
		aplicarRotacionGiroscopio ();
		aplicarCalibracion ();

		if (juegoIniciado) {
			Invoke ("calibraPosicionY", 3f);
			juegoIniciado = false;
		}
	}

	void aplicarRotacionGiroscopio() {
		VRCamaras.transform.rotation = Input.gyro.attitude; // Orientacion en el espacio del dispositivo
		VRCamaras.transform.Rotate(0f,0f,180f,Space.Self);
		VRCamaras.transform.Rotate(90f,180f,0f,Space.World);
		posicionGiroY = VRCamaras.transform.eulerAngles.y;
	}

	void calibraPosicionY() {
		calibrarPosicionY = posicionGiroY - posicionInicialY;
	}

	void aplicarCalibracion() {
		VRCamaras.transform.Rotate (0f, -calibrarPosicionY, 0f, Space.World);
	}
}
