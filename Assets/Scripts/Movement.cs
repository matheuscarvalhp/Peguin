using UnityEngine;
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
	public Image VidasImage;
	public Sprite[] VidasSprites;
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
	void animacaovidas(){
	switch (vidas) {
	case 8:
		VidasImage.sprite = VidasSprites [0];
		break;
	case 7:
		VidasImage.sprite = VidasSprites [1];
		break;
	case 6:
		VidasImage.sprite = VidasSprites [2];
		break;
	case 5:
		VidasImage.sprite = VidasSprites [3];
		break;
	case 4:
		VidasImage.sprite = VidasSprites [4];
		break;
	case 3:
		VidasImage.sprite = VidasSprites [5];
		break;
	case 2:
		VidasImage.sprite = VidasSprites [6];
		break;
		case 1:
			VidasImage.sprite = VidasSprites [7];
			break;
		}


	}
}
