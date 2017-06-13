using UnityEngine;
using System.Collections;

public class moviment : MonoBehaviour {


	public float Velocidade;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-Velocidade ,0f );
		Invoke ("Destruir", 8f);

	}
	void Destruir()
	{
		Destroy (gameObject);
	}


}
