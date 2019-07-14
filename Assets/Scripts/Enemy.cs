using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public string EnemyName = "Enemy to rename";
    public int Life = 3;
    public float MoveSpeed = 1.4f;
    private bool IsAlive = false;
    public Rigidbody2D rg;

    /// <summary>
    /// funzione che arreca danno al nemico
    /// </summary>
    /// <param name="amount"> ammontare del danno inflitto</param>
    public void Damage(int amount)
    {
        Life -= amount;
        if (Life <= 0)
        {
            KillMe();
        }
    }

    /// <summary>
    /// comportamento di morte.
    /// </summary>
    private void KillMe()
    {
        foreach (Collider2D collider in GetComponentsInChildren<Collider2D>())
        {
            collider.enabled = false;
        }
        rg.AddForce(new Vector3(0, 70, 0));
        
    }


}

