using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorVRPlayer : MonoBehaviour {

	private CharacterController playerController;
	private Vector3 movimientoEnDireccion = Vector3.zero;
	private Vector2 entrada;

	private CollisionFlags banderasDeColision;

	public float FuerzaAlTocarSuelo;
	public float MultiplicarGravedad;

	void Start () {
		playerController = GetComponent<CharacterController>();	
	}
	

	void FixedUpdate () {
		Vector3 movimientoDeseado = transform.forward * entrada.y + transform.right * entrada.x; // Para que se mueva a lo largo de la camara

		RaycastHit hitInfo;
		Physics.SphereCast(transform.position, playerController.radius, Vector3.down, out hitInfo, playerController.height / 2f, 
			Physics.AllLayers, QueryTriggerInteraction.Ignore);

		movimientoDeseado = Vector3.ProjectOnPlane(movimientoDeseado, hitInfo.normal).normalized;

		if (playerController.isGrounded) {
			movimientoEnDireccion.y = -FuerzaAlTocarSuelo;
		}
		else {
			movimientoEnDireccion += Physics.gravity * MultiplicarGravedad * Time.fixedDeltaTime;
		}

		banderasDeColision = playerController.Move(movimientoEnDireccion * Time.fixedDeltaTime);
	}
}
