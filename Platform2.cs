using UnityEngine;
using System.Collections;

public class Platform2 : MonoBehaviour {
	
	private bool t = false;

	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update () {
		if (Player.pause == false) 
		{
			if (t)
				transform.position = new Vector2 (transform.position.x - 0.1f, transform.position.y);
			if (!t)
				transform.position = new Vector2 (transform.position.x + 0.1f, transform.position.y);
		
			if (transform.position.x >= 6)
				t = true;
			if (transform.position.x <= -6)
				t = false;
		}
	}
}
