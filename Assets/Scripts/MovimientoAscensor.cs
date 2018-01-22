using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAscensor : MonoBehaviour {

	public GameObject puerta1;
	public GameObject puerta2;
	public GameObject personaje;
	public AudioClip sonidoPuertasAbriendo;
	public AudioClip sonidoPuertasCerrando;
	public AudioClip sonidoAscensor;
	public GameObject techo;
	public GameObject luzAscensor;
	//public float volumen = 1.0f;


	private bool pulsada = false;
	private bool puerta1Abierta = true;
	private bool puerta2Abierta = true;
	private bool puerta1Cerrada = false;
	private bool puerta2Cerrada = false;
	private bool personajeDentro = false;
	private bool sonidoPuertaAbiertaReproducido = false;
	private bool sonidoPuertaCerradaReproducido = false;
	private bool sonidoAscensorSubidaReproducido = false;
	private bool sonidoAscensorBajadaReproducido = false;
	private bool pulsadaPanico = false;
	private bool subidoMax = false;

	void Start () {
		
	}
	

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			pulsada = true;
		}
		if(pulsada){
			if (!personajeDentro) {
				if (personaje.transform.localPosition.z < 20.6)
					personaje.transform.Translate (new Vector3 (0, 0, 8f) * Time.deltaTime);
				else {
					personajeDentro = true;
				}
			}
			else {
				if (puerta1Abierta || puerta2Abierta) {
					if (puerta1.transform.localPosition.y < 20.5)
						puerta1.transform.Translate (new Vector3 (-9f, 0, 0) * Time.deltaTime);
					else {
						puerta1Abierta = false;
						puerta1Cerrada = true;
					}
					if (puerta2.transform.localPosition.y < 20.5)
						puerta2.transform.Translate (new Vector3 (-9f, 0, 0) * Time.deltaTime);
					else {
						puerta2Abierta = false;
						puerta2Cerrada = true;
					}
					if (!sonidoPuertaAbiertaReproducido) {
						AudioSource.PlayClipAtPoint (sonidoPuertasCerrando, transform.position);
						sonidoPuertaAbiertaReproducido = true;
					}
				} else if(!subidoMax) {
					if (transform.position.y < 400) {
						if (techo.activeInHierarchy == true)
							techo.SetActive (false);
						transform.Translate (new Vector3 (0, 0, 30f) * Time.deltaTime);
						personaje.transform.Translate (new Vector3 (0, 30f, 0) * Time.deltaTime);
						if (!sonidoAscensorSubidaReproducido) {
							AudioSource.PlayClipAtPoint (sonidoAscensor, transform.position);
							sonidoAscensorSubidaReproducido = true;
						}
					}
				} 
				if (transform.position.y >= 400) {
					subidoMax = true;
					luzAscensor.SetActive (false);
				}
				if(subidoMax){
					if (Input.GetMouseButtonDown (0)) {
						pulsadaPanico = true;
					}
					if (pulsadaPanico) {
						luzAscensor.SetActive (true);
						if (transform.position.y > 205) {
							transform.Translate (new Vector3 (0, 0, -30f) * Time.deltaTime);
							personaje.transform.Translate (new Vector3 (0, -30f, 0) * Time.deltaTime);
							if (!sonidoAscensorBajadaReproducido) {
								AudioSource.PlayClipAtPoint (sonidoAscensor, transform.position);
								sonidoAscensorBajadaReproducido = true;
							}
						} else {
							techo.SetActive (true);
							if (puerta1Cerrada || puerta2Cerrada) {
								if (puerta1.transform.localPosition.y > -0.5)
									puerta1.transform.Translate (new Vector3 (9f, 0, 0) * Time.deltaTime);
								else {
									puerta1Abierta = true;
									puerta1Cerrada = false;
								}
								if (puerta2.transform.localPosition.y > -1.2)
									puerta2.transform.Translate (new Vector3 (9f, 0, 0) * Time.deltaTime);
								else {
									puerta2Abierta = true;
									puerta2Cerrada = false;
								}
								if (!sonidoPuertaCerradaReproducido) {
									AudioSource.PlayClipAtPoint (sonidoPuertasAbriendo, transform.position);
									sonidoPuertaCerradaReproducido = true;
								}
							}
						}
					}
				}
					
			}
		}

	}	
}
