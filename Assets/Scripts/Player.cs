using System;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Color;

public class Player : MonoBehaviour
{
    // •  CONNECTIONS • 
    public GameManager gameManager;
    // ? / public Material myMaterial = GameObject.GetComponent<Renderer>().material;
    
    // • PLAYER STATS •
    public string playerName;
    public int hp;
    public int points;

    public enum Team
    {
        redTeam, blueTeam, yellowTeam, greenTeam
    }
    
    // • MOVEMENT VARIABLES • 
    public Vector3 direction;
    public float movementSpeed;
    public int jumpHeight = 2;
    public bool movementAllowed;
    private static readonly int EmissionColor = Shader.PropertyToID("_EmissionColor");

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // MOVEMENT ALLOWED RAYCAST: To allow movement abilities only while on ground.
        if (Physics.Raycast(transform.position, Vector3.down, 1.05f))
        {
            movementAllowed = true;
            gameObject.GetComponent<Rigidbody>().drag = 5;
        } else
        {
            gameObject.GetComponent<Rigidbody>().drag = 0;
            movementAllowed = false;
        }
        
        // ACTIVATE: Kill Function
        if (hp < 1) Death();
    }

    private void FixedUpdate()
    {
        if (movementAllowed)
        {
            GetComponent<Rigidbody>().AddForce(direction * movementSpeed);
        }
    }
    
    // SPOTLIGHT FEEDBACK: Make Character Glow to show they are in the correct spotlight.

    public void OnTriggerStay(Collider other)
    {
        if (other != null && other.gameObject.GetComponent<SpotlightMarker>())
        {
            print("You entered a spotlight.");
            // ? / myMaterial.SetColor(EmissionColor, Color.red);
        }
    }
    
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject != null && other.gameObject.GetComponent<SpotlightMarker>())
        {
            print("You exited a spotlight.");
            // ? / myMaterial.SetColor(EmissionColor, Color.black);

        }
    }
    
    
    
    public void TakeDamage()
    {
        hp -= 1;
    }

    /* private void EnterSpotlight()
    {
        
    } */

    /* private void ExitSpotlight()
     {
         
     } */
    

    public void AddPoints()
    {
        points += 1;
    }

    public void Death()
    {
        print("You died.");
        hp = gameManager.GetComponent<GameManager>().maxHealth;
    }
}