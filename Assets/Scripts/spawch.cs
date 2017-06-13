using UnityEngine;
using System.Collections;

public class spawch : MonoBehaviour {
	// Use this for initialization
	public GameObject obj;
	public Transform MaxINST, MinINST ;
	public float minTime, maxTime ;
	public bool status;

	// Use this for initialization
	void Start () {
		status = true;
		StartCoroutine (Spawner ());

	}

	// Update is called once per frame
	void Update(){

			


	}
	IEnumerator Spawner() {

		while (true) 
		{
			yield return new WaitForSeconds (Random.Range (minTime, maxTime));
			if (status) {
				Vector3 v = transform.position;
				v.y = Random.Range (MinINST.position.y, MaxINST.position.y);
				v.z = 0f;
				Instantiate (obj, v, Quaternion.identity);
			}
		}
	}
	public void MudarEstadoDoSpawn()
	{
		status = !status;
	}
}