using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPrompts : MonoBehaviour
{

    public List<int> buttonPrompts;
    public int customLimit;

    public string currentPrompt;

    public TextMeshProUGUI currentPromptDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        GeneratePromptString(customLimit);
    }

    // Update is called once per frame
    void Update()
    {
        currentPromptDisplay.text = currentPrompt;
        
        // • CONTROLS • //
        
        //< I know that this could probably be one
        
        // UP ARROW
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (buttonPrompts[0] == 0)
            {
                CorrectInput(); 
            } else {
                // FEEDBACK FOR INCORRECT INPUT
                gameObject.GetComponent<PlayerManager>().TakeDamage();
            }
        }
        
        // RIGHT ARROW
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (buttonPrompts[0] == 1)
            {
                CorrectInput(); 
            } else {
                // FEEDBACK FOR INCORRECT INPUT
                gameObject.GetComponent<PlayerManager>().TakeDamage();
            }
        }
        
        // DOWN ARROW
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (buttonPrompts[0] == 2)
            {
                CorrectInput(); 
            } else {
                // FEEDBACK FOR INCORRECT INPUT
                gameObject.GetComponent<PlayerManager>().TakeDamage();
            }
        }
        
        // LEFT ARROW
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (buttonPrompts[0] == 3)
            {
                CorrectInput(); 
            } else {
                // FEEDBACK FOR INCORRECT INPUT
                gameObject.GetComponent<PlayerManager>().TakeDamage();
            }
        }
        
        // • UI • //

        switch (buttonPrompts[0])
        {
            case 0:
                currentPrompt = "UP";
                break;
            case 1:
                currentPrompt = "RIGHT";
                break;
            case 2:
                currentPrompt = "DOWN";
                break;
            case 3:
                currentPrompt = "LEFT";
                break;
        }
        
    }

    void GeneratePromptString(int promptLimit)
    {
        for(int i = 0; i < promptLimit; i++) 
        { 
            buttonPrompts.Add(Random.Range(0, 3));
        }
    }

    public void CorrectInput()
    {
        gameObject.GetComponent<PlayerManager>().AddPoints();
        buttonPrompts.RemoveAt(0);
    }


}
