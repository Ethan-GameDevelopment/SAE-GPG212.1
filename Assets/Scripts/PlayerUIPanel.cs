using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIPanel : MonoBehaviour
{
    public GameObject gameManager;

    public GameObject player;
    //public GameObject gameManager;

    public TextMeshProUGUI playerName;
    public TextMeshProUGUI currentHp;
    public TextMeshProUGUI score;

    public Slider HpSlider;


    // Start is called before the first frame update
    private void Start()
    {
        playerName.text = player.GetComponent<Player>().playerName;
    }

    // Update is called once per frame
    private void Update()
    {
        currentHp.text = "♥ " + player.GetComponent<Player>().hp;
        score.text = player.GetComponent<Player>().points + " ♦";
        HpSlider.value = player.GetComponent<Player>().hp;
        HpSlider.maxValue = gameManager.GetComponent<GameManager>().maxHealth;
    }
}