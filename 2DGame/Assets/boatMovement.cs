using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatMovement : MonoBehaviour {

	public float Speed = 10f;
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {

		float Dirx = Speed * Time.deltaTime;
		transform.position = new Vector2 (transform.position.x + Dirx, transform.position.y);

	}

}