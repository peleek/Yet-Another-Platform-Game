﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	public int rotate=10;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.deltaTime%2 >1)
			transform.Rotate(new Vector3 (0, 0, rotate * Time.deltaTime));
		if (Time.deltaTime%2 <1)
			transform.Rotate(new Vector3 (0, 0, -rotate * Time.deltaTime));

		
	}
}
