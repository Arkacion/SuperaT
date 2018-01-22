using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class spawner : MonoBehaviour {

	public Transform[] spawnLocations;
	public GameObject[] whatToSpawnPerfab;
	public GameObject[] whatToSpawnClone;
	private int iter = 0;


 	void Start () {
	}
	
	void Update() {
		if (iter < whatToSpawnPerfab.Length) {
			whatToSpawnClone[iter] = Instantiate(whatToSpawnPerfab[iter], 
			spawnLocations[iter].transform.position, Quaternion.Euler(-90,0,0)) as GameObject;
			
			Thread.Sleep(8000);
			iter++;
		}
		
	}

}
