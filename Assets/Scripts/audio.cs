using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class audio : MonoBehaviour {
	
	public Image som;
	public Sprite somoff, somon;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	public void onClick()
	{
		AudioSource audio = GetComponent<AudioSource> ();
		if (audio.isPlaying) {
			audio.Pause ();
			som.sprite = somoff;
		} else
		{
			audio.Play ();
			som.sprite = somon;
		}
	}
	}


