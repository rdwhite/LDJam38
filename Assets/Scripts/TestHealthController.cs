using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHealthController : MonoBehaviour {

    private HealthBarController healthBar;

    private void Awake () {
        healthBar = GameObject.Find("healthbar").GetComponent<HealthBarController>();
    }
    
	
	// Update is called once per frame
	void Update () {
	    //if (Input.GetKey(KeyCode.UpArrow)) healthBar.changeHealthPoints(1);
     //   if (Input.GetKey(KeyCode.DownArrow)) healthBar.changeHealthPoints(-1);
	}
}
