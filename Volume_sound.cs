using UnityEngine;
using System.Collections;

public class Volume_sound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<UIScrollBar>().value = Player.volume_x;
	}
	
	// Update is called once per frame
	void Update () {
		Player.volume_x = GetComponent<UIScrollBar>().value;
	}
}
