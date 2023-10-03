using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    
    public string playerName;
    
    public int hp;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < 1)
        {
            Death();
        }
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
        
    }
}
