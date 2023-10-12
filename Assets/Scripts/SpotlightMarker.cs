using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class SpotlightMarker : MonoBehaviour
{
    // •  CONNECTIONS • 
    public SpotLight spotlightMarker;
    
    // • SPOTLIGHT STATS • 
    public enum Team
    {
        redTeam, blueTeam, yellowTeam, greenTeam
    }
    
    // connected player Variable
    public Color32 markerColour;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        ConfigureSpotlightMarker(Color32 inputColour)
        {
            spotlightMarker.color = markerColour;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConfigureSpotlightMarker(enum inputTeam, Color32 teamColour)
    {
        Team = inputTeam;
        markerColour = teamColour;
    }
}
