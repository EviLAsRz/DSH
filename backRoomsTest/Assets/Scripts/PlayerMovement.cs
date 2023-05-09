using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator playerAnim;
    public Rigidbody playerRigid;
    public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed;
    public bool walking;
    public Transform playerTrans;

    private void Start()
    {
        playerAnim.SetTrigger("idle");
        walking = false;
    }

    bool isMoving = false;
    void Update()
    {
      
        Debug.Log("Pre moverse: " + isMoving);
        // Check for W key
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAnim.SetTrigger("walk");
            playerAnim.ResetTrigger("idle");
            walking = true;
            isMoving = true;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.ResetTrigger("walk");
            playerAnim.SetTrigger("idle");
            walking = false;
        }
        // Check for S key
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerAnim.SetTrigger("walkback");
            playerAnim.ResetTrigger("idle");
            walking = true;
            isMoving = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.ResetTrigger("walkback");
            playerAnim.SetTrigger("idle");
            walking = false;
        }

        // Check for A key
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerAnim.SetTrigger("sideWalk");
            playerAnim.ResetTrigger("idle");
            walking = true;
            isMoving = true;
        }

        if (Input.GetKeyUp (KeyCode.A))
        {
            playerAnim.ResetTrigger("sideWalk");
            playerAnim.SetTrigger("idle");
            walking = false;
        }

        // Check for D key
        if (Input.GetKey(KeyCode.D))
        {
            isMoving = true;
        }

        Debug.Log("Post moverse: " + isMoving);
        // Check for Left Shift key
        if (walking)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                w_speed = w_speed + rn_speed;
                playerAnim.SetTrigger("run");
                playerAnim.ResetTrigger("walk");
                isMoving = true;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                playerAnim.ResetTrigger("run");
                playerAnim.SetTrigger("walk");
            }
        }
        
        // Check if not moving
        if (!isMoving)
        {
            walking = false;
            playerAnim.SetTrigger("idle");
        }
        /*
        Debug.Log("Idle: " + playerAnim.GetBool("idle"));
        Debug.Log("walk: " + playerAnim.GetBool("walk"));
        Debug.Log("run: " + playerAnim.GetBool("run"));
        Debug.Log("walkback: " + playerAnim.GetBool("walkback"));
        */
        Debug.Log("sideWalk: " + playerAnim.GetBool("sideWalk"));
        
    }
}