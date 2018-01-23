using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caminar : MonoBehaviour {

	public GameObject visionVR;
	public const int anguloRecto = 90;
	public bool isWalking = false;
	public float velocidad;
	public bool caminarCuandoPulsamos;
	public bool caminarCuandoMiramos;
	public double anguloDelUmbral;
	public bool congelarPosicionY;
	public float compensarY;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (caminarCuandoMiramos && !caminarCuandoPulsamos && !isWalking &&
		    visionVR.transform.eulerAngles.x >= anguloDelUmbral && visionVR.transform.eulerAngles.x <= anguloRecto) {

			isWalking = true;
		} else if (caminarCuandoMiramos && !caminarCuandoPulsamos && isWalking &&
		        (visionVR.transform.eulerAngles.x <= anguloDelUmbral || visionVR.transform.eulerAngles.x >= anguloRecto)) {
			isWalking = false;
		}
		if (isWalking) {
			Camina ();
		}
		if (congelarPosicionY) {
			transform.position = new Vector3 (transform.position.x, compensarY, transform.position.z);
		}
	}

	public void Camina() {
		Vector3 direccion = 
			new Vector3(visionVR.transform.forward.x, 0, visionVR.transform.forward.z).normalized * velocidad * Time.deltaTime;
		Quaternion rotacion = Quaternion.Euler(new Vector3(0,transform.rotation.eulerAngles.y, 0));
		transform.Translate(rotacion * direccion);
	}
}
