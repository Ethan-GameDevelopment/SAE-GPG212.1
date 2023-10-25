using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightMovingState : MonoBehaviour
{ 
    private void OnEnable()
    {
        gameObject.GetComponent<Light>().color = Color.black;
        // Set movement speed as an amount and set it 
        // set interactable = false
        
    }

    private void Update()
    {
        throw new NotImplementedException();
        // move around and randomly change directions and slide around the stage
    }

    private void OnDisable()
    {
        throw new NotImplementedException();
    }
}
