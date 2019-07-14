using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioFallDeath : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        if (player != null)
        {
            //allora è un nemico
            player.Damage(3);
            Rigidbody2D rb = GetComponentInParent<Rigidbody2D>();

        }
    }
}
