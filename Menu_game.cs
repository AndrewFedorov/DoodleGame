using UnityEngine;
using System.Collections;

public class Menu_game : MonoBehaviour {

	private bool sound_x = true;
	private float volume_x = 1.0f;

	void new_game()
	{
		Time.timeScale = 1;
		Player.pause = false;
		Application.LoadLevel(2);
	}

	void settings()
	{
		Application.LoadLevel(1);
	}

	void exit()
	{
		Application.Quit ();
	}

	void resume()
	{
		Time.timeScale = 1;
		Player.pause = false;
	}

	void menu()
	{
		Application.LoadLevel(0);
	}
	void sound()
	{
		if (sound_x == true) 
		{
			Player.volume_x = 0;
			sound_x = false;
			GameObject.Find ("Sound").GetComponent<UIToggle>().startsActive = false;
		}
		else {
			Player.volume_x = 1;
			sound_x = true;
			GameObject.Find ("Sound").GetComponent<UIToggle>().startsActive = true;
		}
	}
}
