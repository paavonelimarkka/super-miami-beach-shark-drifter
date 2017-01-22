using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public float speed;
	public float RotationSpeed;

	private Rigidbody rb;
	private Transform Target;
	private Quaternion _lookRotation;
	private Vector3 _direction;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		Target = GameObject.FindGameObjectWithTag ("Hai").transform;
	}
	
	// Update is called once per frame
	void Update () {
		
		_direction = (Target.position - transform.position).normalized;
		_lookRotation = Quaternion.LookRotation(_direction);
		transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);

		rb.AddRelativeForce (new Vector3 (0.0f,0.0f,speed * 10 * Time.deltaTime));
	}
}
