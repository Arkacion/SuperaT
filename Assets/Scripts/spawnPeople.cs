using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPeople : MonoBehaviour {

	public GameObject area;
	public GameObject[] target;
	private static int i = 0;

	// Use this for initialization
	void Start () {
		
		InvokeRepeating("spawnRamdonPeople", 2, 1);
	}
	

	void spawnRamdonPeople () {

		if (i > 6) { i = 0; }

		float x = Random.Range(area.transform.position.x - 300f, area.transform.position.x + 300f);
		float z = Random.Range(area.transform.position.z - 200f, area.transform.position.z + 200f);
		float rotation = Random.Range (0, 360);

        // Need to check if new person collision between other gameObject.

		
		
		Instantiate (target[i], new Vector3(x, -2, z), Quaternion.Euler(new Vector3(-90, 0, rotation)));
		i = i+1;

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Space)) {
			CancelInvoke ("spawnRamdonPeople");
		}
	}
}
