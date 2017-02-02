using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPointsFromCollision : MonoBehaviour {

	public int pointsToAdd;
	public AudioSource argh;

	// Use this for initialization
	void Start () {
		argh = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Hai" && SetEndScore.GameOver == false) {
			UpdatePoints.points += pointsToAdd;
			argh.Play ();
		}
	}
		
}
