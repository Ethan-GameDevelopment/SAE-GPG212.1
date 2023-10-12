using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // • CONNECTIONS •
    
    // Connect GameManager for playerslots??
    public GameObject gameManager;

    public Player player;
    
    // • MOVEMENTS • 
    
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    
    // • ABILITIES •

    public KeyCode Spin;
    public KeyCode Wave;
    public KeyCode Dive;
    public KeyCode Lunge;

    // Update is called once per frame
    void Update()
    {
        player.direction = Vector3.zero;
        
        if (Input.GetKey(right)) player.direction.z = player.GetComponent<Player>().movementSpeed;

        if (Input.GetKey(left)) player.direction.z = -player.GetComponent<Player>().movementSpeed;

        if (Input.GetKey(up)) player.direction.x = -player.GetComponent<Player>().movementSpeed;

        if (Input.GetKey(down)) player.direction.x = player.GetComponent<Player>().movementSpeed;

        if (Input.GetKey(jump)) player.direction.y += player.GetComponent<Player>().jumpHeight;
    }

    private void FixedUpdate()
    {
        
    }
}

// ?????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????