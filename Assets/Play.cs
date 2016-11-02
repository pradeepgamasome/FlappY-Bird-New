using UnityEngine;
using System.Collections;
using System.IO;

public class Play : MonoBehaviour {
	float y=0;
	float speed;
	float acc;


	// Use this for initialization
	void Start () {


		speed = 1 + Time.deltaTime;
		acc = speed*0.5f;


	}

	float position_y;

	float speed_y = 0;

	float accel_y=2;

	// Update is called once per frame
	void Update () {




	

		speed_y += accel_y*Time.deltaTime;
		position_y -= speed_y;

		transform.position = new Vector3 (0,position_y,0);

		if ( Input.GetKeyDown(KeyCode.UpArrow) )

		{
			
			speed_y =-0.5f;

		}

	}
}
