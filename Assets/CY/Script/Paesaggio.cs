using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paesaggio : MonoBehaviour {

	public GameObject Treno;

	public float DistanzaMassimo = 50f; 

	void Start() {
		Treno = GameObject.FindGameObjectWithTag ("Treno");
	}

	void Update () {
		float DistanzaDalTreno = Vector2.Distance (transform.position, Treno.transform.position);

		if(DistanzaDalTreno > DistanzaMassimo) {
			DestroyObject (gameObject);
		}
	}
}
