using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Busted : MonoBehaviour {

	private GameObject endScreen = HideFromScene.endScreen;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Hai") {
			SetEndScore.GameOver = true;
			endScreen.SetActive (true);
		}
	}

	void Update() {
		if (SetEndScore.GameOver == true && Input.GetKeyDown(KeyCode.Space)) {
			Application.LoadLevel("Menu");
		}
	}

}
