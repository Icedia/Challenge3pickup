using UnityEngine;
using System.Collections;

public class slowing : Coin {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D coll)
	{
		var l_player = coll.gameObject.GetComponent<Player>();//check of de collider gameobject wel onze speler is
		if (l_player != null)//IS dit NIET null dan hebben we de collider van de speler
		{	

			PlayerHit(l_player);
			l_player.speed = l_player.speed / 2;
			Debug.Log(l_player.speed);
			Destroy(this.gameObject);
			
		}
	}

}
