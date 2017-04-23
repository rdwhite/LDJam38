using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickupController : MonoBehaviour {

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "PlayerController")
        {
            gameObject.SetActive(false);
        }
    }
}
