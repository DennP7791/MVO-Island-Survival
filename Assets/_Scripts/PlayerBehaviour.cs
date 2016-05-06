using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerBehaviour {

    public BasePlayer player;
    private Text playerHealthUI;

    public PlayerBehaviour(BasePlayer basePlayer)
    {
        this.player = basePlayer;
        playerHealthUI = GameObject.Find("PlayerHealthPoints").GetComponent<Text>();
    }

    public void UpdatePlayerStats()
    {
        UpdatePlayerUI();
    }

    public void UpdatePlayerUI()
    {
        playerHealthUI.text = "Health Points: " + player.Health + "/" + player.MaxHealth;
    }
}
