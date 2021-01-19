using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedDampTime = 0.01f;

    private Animator anim;
    private HashIDs hash;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        anim.SetLayerWeight(1, 1f);
        hash = GameObject.FindGameObjectWithTag("GameController").GetComponent<HashIDs>();

    }
    private void FixedUpdate()
    {
    }
       

    void Update()
    {
        float v = Input.GetAxis("Vertical");
        MovementManager(v);
    }

    void MovementManager(float vertical)
    {
        if (vertical > 0)
        { 
            anim.SetFloat(hash.speedFloat, 1.5f, speedDampTime, Time.deltaTime);
            anim.SetBool("backwards", false);
        } 
        
         if (vertical < 0)
        { 
            anim.SetFloat(hash.speedFloat, -1.5f, speedDampTime, Time.deltaTime);
            anim.SetBool("backwards", true);
        } 

        if (vertical == 0)
        {
            anim.SetFloat(hash.speedFloat, 0);
            anim.SetBool("backwards", false);
            anim.SetBool("jump", false);   
		}
        
       

        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("turnleft", true);  
		}

        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("turnleft", false);  
		}

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("turnright", true);  
		}

        else if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("turnright", false);  
		}

        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("run", true);  
		}

        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool("run", false);  
		}

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("jump", true);  
		}  
    }
}
