using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour {

    // Use this for initialization
    private Slider healthBar;
    private int currentHealthPoints = 100;

	void Awake () {
        healthBar = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.value = currentHealthPoints;
	}

    public void changeHealthPoints(int dHP) {
        currentHealthPoints += dHP;
    }
}
