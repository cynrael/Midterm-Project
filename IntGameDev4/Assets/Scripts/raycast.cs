using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{

	public float rayDistance = 5;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Ray myRay = new Ray(this.transform.position, Vector3.down);

		Debug.DrawRay(myRay.origin, new Vector3(0, -rayDistance, 0), Color.blue);
		

		if (Physics.Raycast(myRay, rayDistance))
		{
			//print("alwskdsjfalskdjflakdjf");
			transform.Rotate(0, 0, 0);
		}
		else
		{
			transform.Rotate(0, 2, 0);
		}
	}
}
