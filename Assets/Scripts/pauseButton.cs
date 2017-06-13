using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pauseButton : MonoBehaviour {
	public bool paused;
	public Image pausea;
	public Sprite pauseoff, pauseon;
	// Use this for initialization
	void Start () {
		paused = false;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void pause()
	{
		paused = !paused;
		if (paused) {
			Time.timeScale = 0;
			pausea.sprite = pauseon;



		}
		if (!paused) {
			Time.timeScale = 1;
			pausea.sprite = pauseoff;
		}
	}
}
