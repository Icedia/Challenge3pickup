using UnityEngine;
using System.Collections;

public class Slow : Player {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D coll)
	{
		//.transform.position += Vector3.right * Time.deltaTime / 2;
	}
}
