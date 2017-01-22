using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLoadLevel : MonoBehaviour {

	public UnityEngine.UI.Button btn;

	// Use this for initialization
	void Start () {
		btn.onClick.AddListener (ChangeLevel);
	}

	void ChangeLevel () {
		Application.LoadLevel ("uimaskene");
	}

	// Update is called once per frame
	void Update () {

	}
}
