using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyScript : MonoBehaviour {
    protected PlatformerMotor2D _motor;
    private void Awake()
    {
        _motor = GetComponent<PlatformerMotor2D>();
    }
    public virtual void playDeath() {   }
}
