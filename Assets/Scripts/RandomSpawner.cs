using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {

	public GameObject Objekti;
	public int SpawnAmount;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < SpawnAmount; i++)
			Instantiate (Objekti, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
