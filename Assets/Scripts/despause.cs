using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class despause : MonoBehaviour {
	public bool paused=false;


	void Start()
	{
		
	}
	public void pause(){
		if (paused==false) {
			Time.timeScale = 1;
		}
	}
	public void ChangeScene(string cena)
	{
		SceneManager.LoadScene (cena);
	}
}
