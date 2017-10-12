using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SDunitychandemo1 : MonoBehaviour {


    private bool Active;//updateの有効化on/off

    private Animator animator;
    // Use this for initialization
    void Start()
    {
        Active = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Active == true && Input.GetKey("up"))
        {
            transform.position += transform.forward * 0.08f;
            animator.SetBool("isrunning", true);
        }
        else
        {
            animator.SetBool("isrunning", false);
        }
        if (Active == true && Input.GetKey("right"))
        {
            transform.Rotate(0, 3, 0);
        }
        if (Active == true && Input.GetKey("left"))
        {
            transform.Rotate(0, -3, 0);
        }
    }

    public void PlayerActive(bool flag)
    {
        Active = flag;
    }
}
