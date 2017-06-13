using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redemovment : MonoBehaviour {

	public float redespeed;

	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-redespeed ,0f );
		Invoke ("Destruir", 8f);
		}

	void Destruir()
	{
		Destroy (gameObject);
	}
}