using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Connections

    public List<GameObject> playerSlots;
    
    // TEXT ELEMENTS
    
    // • GLOBAL HUD • //
    
    // TIMER?
    
    // • PLAYER 1 • //

    public TextMeshProUGUI p1HP;
    public TextMeshProUGUI p1Points;
    
    // PROMPT

    public TextMeshProUGUI p1Prompt;
    
    // • Player 2 • //

    public TextMeshProUGUI p2HP;
    public TextMeshProUGUI p2Points;
    
    // PROMPT
    
    public TextMeshProUGUI p2Prompt;
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
