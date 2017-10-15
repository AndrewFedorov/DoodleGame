using UnityEngine;
using System.Collections;

public class Main_Camera : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < target.transform.position.y)
			transform.position = new Vector3(transform.position.x, target.transform.position.y, transform.position.z);
	}
}
