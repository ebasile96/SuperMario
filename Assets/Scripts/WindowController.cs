using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour {

    Animator anim;
    public bool open = false;
    public GameObject window;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
        //anim.SetBool("Open", false);
        WindowButtonOFF();

        
    }

    private void Update()
    {
       
    }

    public void WindowButtonON()
    {
        window.SetActive(true);
        anim.SetBool("Open",true);
    }

    public void WindowButtonOFF()
    {
        window.SetActive(false);
        anim.SetBool("Open", false);
        
    }
    
}
