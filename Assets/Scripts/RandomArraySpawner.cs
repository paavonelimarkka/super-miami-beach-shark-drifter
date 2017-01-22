using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomArraySpawner : MonoBehaviour {

	public GameObject[] RandomArray;
	public int SpawnAmount;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < SpawnAmount; i++)
			Instantiate (RandomArray[Random.Range(0,RandomArray.Length)], new Vector3 (Random.Range (-100f, 100f), -0.4f, Random.Range (-100f, 100f)), Quaternion.AngleAxis(Random.Range(0,360.0f), Vector3.up));
	}

	// Update is called once per frame
	void Update () {

	}
}
