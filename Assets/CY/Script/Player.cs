using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Character Personaggio;

	void Start () {
		Personaggio = GetComponent<Character> ();
	}

	void Update () {
		comandi ();		 
	}

	void comandi() {
		if(Input.GetKey(KeyCode.A)) {
			Personaggio.CamminaVersoSinistra ();
		}
		if(Input.GetKey(KeyCode.D)) {
			Personaggio.CamminaVersoDestra ();
		}
	}
}
