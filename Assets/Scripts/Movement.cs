﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour {
	public bool paused;
	public float velocidade = 5;
	public int vidas =3;
	public Text Vidas;
	public GameObject PlayAgain;
	public GameObject Menu;
	public Image BackGameOver;
	Rigidbody2D rg;
	Score total;
void Start(){
		Vidas.text = "Vida:" + vidas;
		BackGameOver.enabled = false;
		paused = false;
		rg = GetComponent<Rigidbody2D> ();
		total = FindObjectOfType<Score> ();
	}
	// Update is called once per frame
	void Update ()
	{

		if (vidas <= 0) {
			Menu.SetActive (true);
			PlayAgain.SetActive (true);
			BackGameOver.enabled = true;
			paused = !paused;
			if (paused) {
				Time.timeScale = 0;
			}
		}


	}

	public void movement ()
	{
		rg.velocity = new Vector2 (0, velocidade);
		if (total.pontos > 120) {
			velocidade = 8;
		}

	}
public void moviment(){


		rg.velocity = new Vector2 (0, -velocidade);
		if (total.pontos > 120) {
			velocidade = 8;
		}



	}

		


		void OnCollisionEnter2D(Collision2D coll){
			if (coll.gameObject.tag == "Enemy") {
		    vidas = vidas - 1;
			Vidas.text = "Vidas:" + vidas;
			Destroy (coll.gameObject);
			}
		if (coll.gameObject.tag == "Peixe") {
			total.pontos += 15;
			Destroy (coll.gameObject);
		}if (coll.gameObject.tag == "PEIXÃO") {
			total.pontos += 30;
			Destroy (coll.gameObject);
		}
		if (coll.gameObject.tag == "life") {
			vidas = vidas + 1;
			Vidas.text = "Vidas:" + vidas;
			Destroy (coll.gameObject);
		}
			}



}
