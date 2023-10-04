﻿using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;

    public string playerName;

    public int hp;
    public int points;

    public Vector3 direction;
    public float speed;
    public int jumpHeight = 2;
    public bool movementAllowed;

    // Movement // 
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    // Attacks //
    // ? / public KeyCode Spin;
    // ? / public KeyCode Wave;
    // ? / public KeyCode Dive;
    // ? / public KeyCode Lunge;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        direction = Vector3.zero;

        // • MOVEMENT • 

        if (movementAllowed)
        {
            if (Input.GetKey(right)) direction.z = speed;

            if (Input.GetKey(left)) direction.z = -speed;

            if (Input.GetKey(up)) direction.x = -speed;

            if (Input.GetKey(down)) direction.x = speed;

            if (Input.GetKey(jump)) direction.y += jumpHeight;
        }


        if (Physics.Raycast(transform.position, Vector3.down, 1.05f))
        {
            movementAllowed = true;
            gameObject.GetComponent<Rigidbody>().drag = 5;
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().drag = 0;
            movementAllowed = false;
        }


        if (hp < 1) Death();
    }

    private void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(direction * speed);
    }

    public void TakeDamage()
    {
        hp -= 1;
    }

    public void AddPoints()
    {
        points += 1;
    }

    public void Death()
    {
        print("You died.");
        hp = gameManager.GetComponent<GameManager>().maxHealth;
    }
}