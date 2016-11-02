using UnityEngine;
using System.Collections;

public class Piller_Repeat : MonoBehaviour {
	
	float f;
	float speed=1.5f;
	public GameObject g;

	// Use this for initialization
	void Start ()
	{
		for (int i = 1; i < 19; i++) 
		{
			Instantiate (g,new  Vector3 ((5*i)+2, 1+Random.Range (-2, 2), 0), Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () {
//		speed = 1.5f;
		transform.position = new Vector3 (this.transform.position.x-speed*Time.deltaTime,this.transform.position.y,0);

		if(transform.position.x<-12)
		{
			transform.position = new Vector3 (55,Random.Range (-4, 4),0);
		}

	}
}
