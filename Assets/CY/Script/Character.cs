using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	/* POSIZIONE
		0: dentro il treno
		1: fuori dal treno
	*/
	public int Posizione = 0;
	public int CambiamentoPos;

	public GameObject OggettoTreno;
	public GameObject SpriteObj;

	private float VelocitaMovimento = 2;
	private float VelocitaCorsa = 2;

	void Start () {
		CambiamentoPos = Posizione;

		// debug parente
		trasformParent();
	}

	void Update () {
		if(CambiamentoPos != Posizione) {
			trasformParent ();

			CambiamentoPos = Posizione;
		}

		// Debug rotazione character
		/*if(transform.eulerAngles != new Vector3(0, transform.transform.eulerAngles.y, 0)) {
			transform.eulerAngles = new Vector3 (0, transform.transform.eulerAngles.y, 0);
			transform.position = new Vector2 (transform.position.x, transform.position.y);
		}*/
	}

	void trasformParent() {
		if(Posizione == 0) {
			transform.parent = OggettoTreno.transform;
		} else {
			transform.parent = null;
		}
	}

	public void CamminaVersoDestra() {
		ruotaVersoDestra ();
		 
		transform.Translate(Vector2.right * VelocitaMovimento * Time.deltaTime);
	}

	public void CamminaVersoSinistra() {
		ruotaVersoSinistra ();

		transform.Translate(Vector2.left * VelocitaMovimento * Time.deltaTime);
	}

	public void ruotaVersoSinistra() {
		SpriteObj.transform.eulerAngles = new Vector3(0,180,0);
	}

	public void ruotaVersoDestra() {
		SpriteObj.transform.eulerAngles = new Vector3(0,0,0);
	}
}
