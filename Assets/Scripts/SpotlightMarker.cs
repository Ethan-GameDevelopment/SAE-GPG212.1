using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class SpotlightMarker : MonoBehaviour
{
    // •  CONNECTIONS • 
    
    
    // • SPOTLIGHT STATS • 
    public enum Team
    {
        redTeam, blueTeam, yellowTeam, greenTeam
    }
    
    // connected player Variable
    // public int markerColour;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        gameObject.GetComponent<Light>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* public void ConfigureSpotlightMarker(Color32 teamColour)
    {
        
        markerColour = teamColour;
    } */
}
