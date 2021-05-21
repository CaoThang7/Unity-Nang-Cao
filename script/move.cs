using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D col)
	{
        GameControlScript.moneyAmount+= 1;
		Destroy(gameObject);
	}
}
