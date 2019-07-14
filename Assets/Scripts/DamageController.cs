using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour {

    public float BouncingForce = 200;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            //allora è un nemico
            enemy.Damage(3);
            Rigidbody2D rb = GetComponentInParent<Rigidbody2D>();
            if (rb != null)
            {
                //rimbalzo per il danno
                rb.AddForce(new Vector3(0, BouncingForce, 0));
                
            }
        }

    }

}
