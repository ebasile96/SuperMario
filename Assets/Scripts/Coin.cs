using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        Coin coin = other.gameObject.GetComponent<Coin>();
        if (player != null)
        {
            
            
            Coin.Destroy(this.gameObject);
            player.CoinTotal++;

        

            
        }
    }

    
}
