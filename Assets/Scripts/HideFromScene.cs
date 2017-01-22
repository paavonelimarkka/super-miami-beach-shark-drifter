using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideFromScene : MonoBehaviour {

	public static GameObject endScreen;

	void Awake() {
		endScreen = GameObject.FindGameObjectWithTag("EndScreen");
		endScreen.SetActive (false);
	}

	// Use this for initialization
	void Start () {
		
	}

}
