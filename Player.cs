using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public AudioClip jump;
	public GameObject menu_pause;
	static public float volume_x = 1.0f;
	private float time_jump;
	private bool t = false;
	public static bool pause = false;

	// Use this for initialization
	void Start () {
		audio.volume = volume_x;
	}
	
	// Update is called once per frame
	void Update () {
		if(pause == false)
			menu_pause.SetActive (false);
		if (Input.GetKeyUp(KeyCode.Escape))
		{
		    if(pause == false)
			{
				pause = true;
				Time.timeScale = 0;
				menu_pause.SetActive (true);
			}
			else 
			{
				pause = false;
				Time.timeScale = 1;
				menu_pause.SetActive (false);
			}
		}
		if(pause == false)
		{
			if(Time.time - 1.0f > time_jump)
				GetComponent<BoxCollider2D>().enabled = true;
			if (Input.GetKey(KeyCode.A)) 
				transform.position = new Vector2(transform.position.x - 0.1f, transform.position.y);
			if(Input.GetKey(KeyCode.D))
				transform.position = new Vector2(transform.position.x + 0.1f, transform.position.y);
			if(Input.GetKey(KeyCode.LeftArrow))
				transform.position = new Vector2(transform.position.x - 0.1f, transform.position.y);
			if(Input.GetKey(KeyCode.RightArrow))
				transform.position = new Vector2(transform.position.x + 0.1f, transform.position.y);
			if ((Time.time > time_jump + 2.0f)&&(t == true))
				Application.LoadLevel(3);
		}
	}


void OnCollisionEnter2D(Collision2D myCollider)
{
	if(myCollider.gameObject.tag == "Platform")
	{
		gameObject.rigidbody2D.AddForce(new Vector2(0, 400));
		audio.PlayOneShot(jump);
		GetComponent<BoxCollider2D>().enabled = false;
		time_jump = Time.time;
		t = true;
	}
}
}