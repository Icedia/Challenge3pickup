using UnityEngine;
using System.Collections;

public class Rotate : Coin {
	//check of de collider gameobject wel onze speler is
	private bool isColliding;
	
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D coll)
	{	
		var l_player = coll.gameObject.GetComponent<Player>();

		if (l_player != null)//IS dit NIET null dan hebben we de collider van de speler
		{	
			
			PlayerHit(l_player);
			l_player.isRotating = true;
			Destroy(this.gameObject);
			
		}
	}

	/*void Update()
	{
		if (isColliding) {
			Rotation();
		}
	}

	void Rotation()
	{

	}*/
}

