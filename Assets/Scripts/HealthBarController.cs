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

    public HealthManager enemyHealthManager;

	void Awake () {
        healthBar = GetComponent<Slider>();
	    healthText = GetComponentInChildren<Text>();
	}
	
	// Update is called at end of frame
	void LateUpdate ()
	{
	    healthBar.maxValue = playerHealthManager.MaxHp;
	    healthBar.value = playerHealthManager.currentHp;
        healthText.text = healthBar.value + "/" + healthBar.maxValue;

        healthBar.maxValue = enemyHealthManager.MaxHp;
        healthBar.value = enemyHealthManager.currentHp;
	}
}
