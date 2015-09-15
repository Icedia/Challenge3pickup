using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public int score = 0;
	public bool isRotating;
	//public Vector3 speed;
	public float speed;
    

    // Update is called once per frame
    void Update()
    {	
		Vector2 moveVector = new Vector2 (speed, 0) * Time.deltaTime;
        //beweeg de speler naar rechts
		transform.Translate (moveVector);
		//this.transform.position += speed;
		/*if (speed == Vector3.right * Time.deltaTime / 2)
		{
			Debug.Log (speed);
		}*/
		if(isRotating)
		{
			this.transform.Rotate(45,45,45);
		}


    }

	public void Score(){
		score += 10;
		Debug.Log (score);
	}
}
