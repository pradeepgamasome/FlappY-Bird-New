﻿using UnityEngine;
using System.Collections;

public class Collide_Play : MonoBehaviour {




	void OnTriggerEnter(Collider other) {
		Destroy(gameObject);
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
