using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yukoDemo1 : MonoBehaviour {

    private Animator animator;
    private bool Active;//updateの有効化on/off
    // Use this for initialization
    void Start()
    {
        Active = true;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Active == true && Input.GetKey("up"))
        {
            transform.position += transform.forward * 0.08f;
            animator.SetBool("is_running", true);
        }
        else
        {
            animator.SetBool("is_running", false);
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
