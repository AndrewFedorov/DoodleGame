using UnityEngine;
using System.Collections;

public class Location : MonoBehaviour {

	public GameObject platform1;
	public GameObject platform2;
	float count;
	GameObject[] platforms = null;
	public int number_platform = 10;


	private int a;

	// Use this for initialization
	void Start () {
		platforms = new GameObject[number_platform];
		InstantiatePlatforms();
	}
	
	// Update is called once per frame
	void Update () {
		count = transform.position.y;

		ActivatePlatforms ();
		DeactivatePlatforms ();
	}

	void InstantiatePlatforms()
	{
		platforms[0] = Instantiate (platform1, new Vector2(0, -1), transform.rotation) as GameObject;
		for (int i = 1; i < number_platform; i++) 
		{
			a = Random.Range(0, 100);
			if((a >= 0) && (a < 50))
				platforms [i] = Instantiate (platform1, new Vector2(Random.Range(-6, 7), count + i), transform.rotation) as GameObject;
			if((a >= 50) && (a < 100))
				platforms [i] = Instantiate (platform2, new Vector2(Random.Range(-6, 7), count + i), transform.rotation) as GameObject;
			platforms [i].SetActive (false);
		}
	}

	void ActivatePlatforms ()
	{
		for (int i = 0; i < number_platform; i++) 
		{
			if(platforms[i].active == false)
			{
				platforms[i].SetActive(true);
				platforms[i].transform.position = new Vector2(Random.Range(-6, 7), count + i);
				return;
			}
		}
	}

	void DeactivatePlatforms ()
	{
		for (int i = 0; i < number_platform; i++) 
		{
			if((count - 5 > platforms[i].transform.position.y) && (platforms[i].active == true))
			{
				platforms[i].SetActive(false);
				return;
			}
		}
	}
}
