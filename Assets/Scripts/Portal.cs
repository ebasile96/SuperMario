using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {

    public int TotalCoins = 0;
    public Player player;


    private void Start()
    {
        TotalCoins = FindObjectsOfType<Coin>().Length;
    }

    private void Update()
    {
        if (player.CoinTotal == TotalCoins)
        {
            GetComponent<Collider2D>().enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player != null)
        {
            Debug.Log("Hai vinto");
            player.anim.SetTrigger("Win");
            player.GameNotEnded = false;

            
        }
    }

}
