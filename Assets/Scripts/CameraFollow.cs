﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public GameObject player;   //Public variable to store a reference to the player game object
    private Transform tform;


    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        tform = transform;
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if (!GameManager.instance.PlayerHasControl) return;
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        tform.position = player.transform.position + offset;
    }
}