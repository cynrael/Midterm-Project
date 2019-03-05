using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
	public Canvas canvas;
	public bool CanvasToggleOn;
	
	// Use this for initialization
	void Start () {
		canvas.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			CanvasToggleOn = !CanvasToggleOn;
			canvas.gameObject.SetActive(CanvasToggleOn);
		}
	}
}
