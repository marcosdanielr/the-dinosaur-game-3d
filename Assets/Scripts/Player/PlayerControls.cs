using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour 
{
    public GameObject stand;
    public GameObject crouch;
    public Rigidbody rb;    
    
    bool isJumping;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(5, rb.velocity.y);

        if (Input.GetKey("space") && isJumping == false)
        {
            rb.velocity = new Vector3(0, 10, 0);
            isJumping = true;
        }

        if (Input.GetKey("down") && isJumping == false)
        {
            crouch.SetActive(true);
            stand.SetActive(false);
        }   
    }

    private void OnCollisionEnter(Collision collisionInfo) 
    {
        isJumping = false;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag=="Obstacle")
        {
            PlayerManager.isGameOver = true;
        }

    }
}
