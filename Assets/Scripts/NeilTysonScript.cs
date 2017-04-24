using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeilTysonScript : EnemyScript
{

    int callCount = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_motor != null)
        {
           
        }
    }

    public override void playDeath()
    {
        GameManager.instance.NeilTysonDefeated = true;
        Destroy(gameObject);
    }
}
