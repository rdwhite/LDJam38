using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeilTysonScript : EnemyScript {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void playDeath()
    {
        Debug.Log("HOLY SHIT WE HIT NEIL TYSON SCRIPT!");
        Destroy(gameObject);
    }
}
