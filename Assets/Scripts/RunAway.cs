using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour {

	public GameObject player;
	public float RunAwaySpeed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = transform.position - player.transform.position;
		direction.Normalize();

		rb.AddForce(direction * RunAwaySpeed);
	}
		
}
