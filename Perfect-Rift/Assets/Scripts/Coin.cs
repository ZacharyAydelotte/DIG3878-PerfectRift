using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    public GameObject collect;
   
	// Use this for initialization
	void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.gameObject.tag == "Player")
        {
                ScoreCount.gscore += 1;
                Destroy(gameObject);
            
        }
	}
}
