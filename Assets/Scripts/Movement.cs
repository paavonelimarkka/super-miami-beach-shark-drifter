using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public GameObject Pelaaja;
	public float Nopeus;
	public float KaantymisNopeus;
	private float powerInput;
	private float turnInput;
	public Rigidbody carRB;
	public AudioSource argh;

	void Start() {
		carRB = GetComponent<Rigidbody>();
	}

	void Update () 
	{
		powerInput = Input.GetAxis ("Vertical");
		turnInput = Input.GetAxis ("Horizontal");
	}

	// Update is called once per frame
	void FixedUpdate () {
		carRB.AddRelativeForce(new Vector3 (0f,0f, powerInput * Nopeus));
		// carRB.AddTorque(0f, turnInput * KaantymisNopeus, 0f);
		Pelaaja.transform.Rotate(new Vector3(0f, turnInput * KaantymisNopeus, 0f));
	}
}
