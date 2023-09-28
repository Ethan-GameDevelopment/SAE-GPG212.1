using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerUIPanel : MonoBehaviour
{
    public GameObject player;
    //public GameObject gameManager;
    
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI currentHp;
    public TextMeshProUGUI score;

    public Slider HpSlider;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = player.GetComponent<Player>().playerName;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentHp.text = "♥ " + player.GetComponent<Player>().hp.ToString();
        score.text = player.GetComponent<Player>().points.ToString() + " ♦";
    }
}
