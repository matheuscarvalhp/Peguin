using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEIXE : MonoBehaviour {
	public float velocidade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += new Vector3 (-velocidade ,0f );
		Invoke ("Destruir", 8f);
		
	}
	void Destruir ()
	{
		Destroy (gameObject);
	}
}


