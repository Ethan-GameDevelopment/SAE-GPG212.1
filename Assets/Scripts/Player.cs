using UnityEngine;

public class Player : MonoBehaviour
{
    // •  CONNECTIONS • 
    public GameManager gameManager;
    
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
    
    public void TakeDamage()
    {
        hp -= 1;
    }

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