using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTreno : MonoBehaviour {

	/* Posizione delt reno
	 * 0: in viaggio
	 * 1: fermo in stazione
	 */
	public int PosizioneDelTreno = 0;
	private float VelocitaTreno = 10f;

	// Tutti i componenti del treno
	public GameObject[] Vagoni;

	// Script esterni
	Character Player;
	int PosizionePlayer;

	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Character> ();
		PosizionePlayer = Player.Posizione;

		// Debug grafica treno
		graficaTreno();
	}
		
	void Update () {
		if(PosizionePlayer != Player.Posizione) {
			graficaTreno ();

			PosizionePlayer = Player.Posizione;
		}

		if(PosizioneDelTreno == 0) { // Treno in movimento
			trenoInMovimento ();
		}
	}

	void graficaTreno() {
		if(Player.Posizione == 0) {
			for(int I=0; I < Vagoni.Length; I++) {
				Vagoni [I].GetComponent<Carrozza> ().internoVagone ();
			}
		} else {
			for(int I=0; I < Vagoni.Length; I++) {
				Vagoni [I].GetComponent<Carrozza> ().esternoVagone ();
			}
		}
	}

	void trenoInMovimento() {
		transform.Translate(Vector2.right * VelocitaTreno * Time.deltaTime);
	}
		
}
