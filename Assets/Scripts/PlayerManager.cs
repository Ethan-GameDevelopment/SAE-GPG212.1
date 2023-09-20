using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int playerHP = 10;
    public int playerPoints;

    public TextMeshProUGUI playerHealthDisplay;
    public TextMeshProUGUI playerPointsDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthDisplay.text = "♥ | " + playerHP + "/ 10";
        playerPointsDisplay.text = "POINTS | " + playerPoints;
    }

    public void TakeDamage()
    {
        playerHP -= 1;
    }

    public void AddPoints()
    {
        playerPoints += 1;
    }



}
