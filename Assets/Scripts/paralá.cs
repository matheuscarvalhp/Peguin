using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class paralá : MonoBehaviour {
	public RawImage image;
	public float speed; 
	Rect rect; 

	void Update ()
	{
		rect = image.uvRect; 
		rect.x += speed * Time.deltaTime;
		image.uvRect = rect;
	}


}
