using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    public int Life=3;
    public int Coins;
    public float MovementSpeed;
    public int JumpForce;
    public bool isGrounded;
    public Rigidbody2D rb;
    public Animator anim;
    bool isAlive = true;
    public int CoinTotal = 0;
    public bool GameNotEnded = true;


    void Start () 
    {
        
        //rg = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Life > 0 && GameNotEnded == true)
        {
            CheckInput();
        }
       
        
  		
	}
    /// <summary>
    /// controllo input movimento player
    /// </summary>
    public void CheckInput() {

        if (Input.GetKey(KeyCode.A)) {

            //SX

            transform.position = transform.position + new Vector3(-MovementSpeed, 0f, 0f);
            anim.SetInteger("Movement", -1);

            
        }else if (Input.GetKey(KeyCode.D)) {

            //DX

            transform.position = transform.position + new Vector3(MovementSpeed, 0f, 0f);

            anim.SetInteger("Movement", 1);
        }
        else
        {
            anim.SetInteger("Movement", 0);
        }
        if (Input.GetKeyDown(KeyCode.W) == true && isGrounded == true)
        {

            //SALTO
 
            
            isGrounded = false;

            rb.AddForce(new Vector2(0, JumpForce));
           

        }
        
        if (Input.GetKeyUp(KeyCode.S)) {

            Debug.Log("accovacciamento");
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        isGrounded = true;
    }

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
        foreach(Collider2D collider in GetComponentsInChildren<Collider2D>())
        {
            collider.enabled = false;
        }
        rb.AddForce(new Vector3(0, 100, 0));
        isAlive = false;
        anim.SetTrigger("Death");
    }

    
}
