using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI CoinsCounter;
    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.maxValue = player.maxhealth;
        healthBar.value = player.health;

        CoinsCounter.text = "coins:"+ player.coins;

    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = player.maxhealth;
        CoinsCounter.text = "coins:" + player.coins;
    }
}
