using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour {

    // Use this for initialization
    Text healthText;
    private Slider healthBar;
    public HealthManager playerHealthManager;

	void Awake () {
        healthBar = GetComponent<Slider>();
	    healthText = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    healthBar.maxValue = playerHealthManager.MaxHp;a
	    healthBar.value = playerHealthManager.currentHp;
        healthText.text = healthBar.value + "/" + healthBar.maxValue;
	}
}
