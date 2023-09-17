using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public Text coinText;


    public void QuitGame()
    {
        Application.Quit();
    }
    
    void Start() {
        coinText.text = "Total Coins: " + ItemCollector.coins;
    }
}
