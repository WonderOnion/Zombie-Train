using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrozza : MonoBehaviour {

	public GameObject SpriteGrafica;
	public Sprite[] Grafica = new Sprite[2];

	public void internoVagone() {
		SpriteGrafica.GetComponent<SpriteRenderer> ().sprite = Grafica[1];
	}

	public void esternoVagone() {
		SpriteGrafica.GetComponent<SpriteRenderer> ().sprite = Grafica[0];
	}

}
