using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour {
	
	public static float Velocidade;

  
	void Start () {
		Velocidade = 0.3f;
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


	
