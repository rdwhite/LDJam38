using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour {

    // Use this for initialization
    private Slider healthBar;
    private int currentHealthPoints = 100;
    public HealthManager playerHealthManager;

	void Awake () {
        healthBar = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    healthBar.maxValue = playerHealthManager.MaxHp;
	    healthBar.value = playerHealthManager.currentHp;
	}
}
