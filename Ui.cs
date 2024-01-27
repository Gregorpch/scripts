using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui : MonoBehaviour
{
    public static Ui singleton;
    public GameObject panel;
    public Text panelScoreText;
    public Text defeatText;
    public Text victoryText;
    public Text TotalScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        panelScoreText.text = Player.score.ToString();
    }
    void Awake()
    {
        singleton = this;
    }

    public static void Victory()
    {
        singleton.panel.SetActive(true);
        singleton.victoryText.gameObject.SetActive(true);
        singleton.TotalScore.text = Player.score.ToString();
    }

    public static void Defeat()
    {
        singleton.panel.SetActive(true);
        singleton.defeatText.gameObject.SetActive(true);
        singleton.TotalScore.text = Player.score.ToString();
    }

    public void Reset()
    {
     Player.Restart();
    }
}
