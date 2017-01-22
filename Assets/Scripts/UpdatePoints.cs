using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePoints : MonoBehaviour {

	public static int points;
	public UnityEngine.UI.Text score;
	private string kekkala;

	// Use this for initialization
	void Start () {
		SetEndScore.GameOver = false;
		points = 0;
	}

	// Update is called once per frame
	void Update () {
		kekkala = points.ToString ();
		score.text = kekkala;
	}
}
