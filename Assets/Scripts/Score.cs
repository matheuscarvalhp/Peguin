using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
public	Text total;
	public float pontos;
	public float level;
	public Spawn plus;


	void Start()
	{   
		
		pontos = 0;
		total.text = "Score: " + pontos;
		StartCoroutine (gg ());
		}
	void Update(){
		if (level >= 100) {
			if (plus.maxTime > 1) {
				plus.maxTime -= 1;
			
			}
		
			if (EnemyMovement.Velocidade < 0.8f) {
				EnemyMovement.Velocidade += 0.1f;
			}
		}
			
				


	}




	IEnumerator gg ()
	{
		while (true) {
			yield return new WaitForSeconds (0.3f);

			pontos = pontos + 1;
			level = level + 1;
			total.text = "Score: " + pontos;
			PlayerPrefs.GetString ("pontos");
			PlayerPrefs.Save ();



	}
}
		

}

