using System;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class PlayerPrompts : MonoBehaviour
{
    public enum DirectionDirection
    {
        upDance, dpwnDance, leftDance, rightDance
    }
    public Queue<Enum> danceQueue;

    public Color attackColour;


    public enum attackStrength
    {
        weak, strong
    }
    // will inform damage, speed, spotlight radius


    public class DancePrompts
    {
        public DirectionDirection directionDirection;
        public Image image;
        public AudioClip sound;
    }
    
    
    public int dancepromptLimit;

    // Start is called before the first frame update
    private void Start()
    {
        GeneratePromptString(dancepromptLimit);
    }

    // Update is called once per frame
    private void Update()
    {
        // • CONTROLS • //

        // UP ARROW
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            EvaluateInput(DirectionDirection.upDance);
        }
    }

    private void GeneratePromptString(int promptLimit)
    {
        int randomDancePrompt = Random.Range(0, Enum.GetNames(typeof(DancePrompts)).Length);
        for (var i = 0; i < promptLimit; i++) danceQueue.Enqueue((DirectionDirection)randomDancePrompt);
    }

    public void EvaluateInput(Enum input)
    {
        gameObject.GetComponent<Player>().AddPoints();
        
        if (danceQueue.Count > 0)
        {
            if (input == danceQueue.Peek())
            {
                danceQueue.Dequeue();
                if (danceQueue.Count == 0)
                {
                    // PLAYER DID COMBO
                    // Cancel any other player doing same combo in the same light
                    // This probably will need to be an event
                }
            }
            else
            {
                // BUZZ WRONG
                // Explode them away
                // rigidbody.AddExplosionForce()
            }
        }
    }

}