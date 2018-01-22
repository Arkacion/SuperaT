using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawnPeople : MonoBehaviour {

	public GameObject person;
	public GameObject[] poeple;
	public float spawnTime = 100f;

	// Use this for initialization
	void Start () {
		//people = GameObject.FindGameObjectsWithTag ("person");
		//InvokeRepeating ("PeopleSpawn", spawnTime, spawnTime);
	}
/*
	public void PeopleSpawn() {
		if (people.Length < 3) {
			Vector3 randomSpawn = new Vector3 (Random.Range (17f, -17f), 0.1f, Random.Range (-19f, 19f));
			Instantiate (person, randomSpawn, transform.rotation);
		}
	}
*/
}
