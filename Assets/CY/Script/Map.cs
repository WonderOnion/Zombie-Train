using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

	// posizione per lo sfondo davanti e dietro
	public int LunghezzaPaesaggio = 8;
	public float DistanzaSfondoDavanti = 4;
	public float DistanzaSfondoDietro  = 4;
	private float IndiceDa = 0, IndiceDi = -8;

	// Variabili per la stampa dello sfondo
	public GameObject PrefabSfondo;

	public GameObject Treno;

	void Start () {
		stampaMappaSonfo ();
	}

	void Update () {
		stampaMappaSonfo ();
	}

	void stampaMappaSonfo() {
		int PosizionePlayer = Mathf.RoundToInt (Treno.transform.position.x); 

		// Davanti
		if(IndiceDa == 0 || IndiceDa < (Treno.transform.position.x + (LunghezzaPaesaggio * DistanzaSfondoDavanti))) {
			Instantiate (PrefabSfondo, new Vector2 (IndiceDa, 3.5f), Quaternion.identity);

			IndiceDa = IndiceDa + LunghezzaPaesaggio;
		}
	}
}
