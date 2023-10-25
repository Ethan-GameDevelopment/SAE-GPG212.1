using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightStateManager : MonoBehaviour
{
  public MonoBehaviour startingState;
  public MonoBehaviour currentState;

  public float currentCooldown;
  public int readyUptime;
  public int movingUptime;
  
 
  // Set a default state
  private void Start()
  {
     ChangeState(startingState);
  }
  
  // This works for ANY STATE
  public void ChangeState(MonoBehaviour newState)
  {
     // Check if the state is the same and DON'T swap
     if (newState == currentState)
     {
        return;
     }

     // At first 'currentstate' will ALWAYS be null
     if (currentState != null)
     {
        currentState.enabled = false;
     }

     newState.enabled = true;

     // New state swap over to incoming state
     currentState = newState;
  }
}

// MY BRAIN IS NOT WORKING RIGHT NOW