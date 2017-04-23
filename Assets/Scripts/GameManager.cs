using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //values that can be saved to during game
    [HideInInspector] public HealthManager PlayerHealthManager;
    [HideInInspector] public DamageType CurrentDamageType;
    [HideInInspector] public ArmorManager resistances;

    public bool PlayerHasControl = false;
	void Awake()
	{
	    if (instance == null) instance = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject); // cause it to persist between scenes.
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
