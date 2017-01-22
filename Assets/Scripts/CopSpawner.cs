using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopSpawner : MonoBehaviour {


	public GameObject poliisi;

	public int spanwPoint_1;
	public int spanwPoint_2;
	public int spanwPoint_3;
	public int spanwPoint_4;
	public int spanwPoint_5;

	private GameObject[] amountOfCops;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		amountOfCops = GameObject.FindGameObjectsWithTag ("Poliisi");
		if (UpdatePoints.points == spanwPoint_1) {
			if (amountOfCops.Length < 1) {
				Instantiate (poliisi, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
			}
		}
		if (UpdatePoints.points == spanwPoint_2) {
			if (amountOfCops.Length < 2) {
				Instantiate (poliisi, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
			}
		}
		if (UpdatePoints.points == spanwPoint_3) {
			if (amountOfCops.Length < 3) {
				Instantiate (poliisi, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
			}
		}
		if (UpdatePoints.points == spanwPoint_4) {
			if (amountOfCops.Length < 4) {
				Instantiate (poliisi, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
			}
		}
		if (UpdatePoints.points == spanwPoint_5) {
			if (amountOfCops.Length < 5) {
				Instantiate (poliisi, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
			}
		}
	}
}
