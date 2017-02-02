using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEndScore : MonoBehaviour {

	public static bool GameOver;
	//private UnityEngine.UI.Text kekkala;
	private int loppuSaatanaPisteet;
	public UnityEngine.UI.Text kala;

	// Use this for initialization
	void Start () {
		GameOver = false;
		loppuSaatanaPisteet = UpdatePoints.points;
	}

	// Update is called once per frame
	void Update () {
        if (GameOver == false)
        {
            loppuSaatanaPisteet = UpdatePoints.points;
            kala.text = loppuSaatanaPisteet.ToString();
        }
		if (GameOver == true) {
			kala.text = loppuSaatanaPisteet.ToString();
		}
		
	}
}
