﻿using UnityEngine;
using System.Collections;

public class MyCamera: MonoBehaviour 
{
	public GameObject target;
	// Use this for initialization
	void Start () 
	{
		/*transform.position = new Vector3(
			transform.position.x,
			transform.position.y,
			transform.position.z);*/
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	   transform.position = new Vector3 (
			target.transform.position.x,
			target.transform.position.y,
			transform.position.z);
	}
}
