using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Hit something!");
        if(collision.collider.tag == "Obstacle")
        {
            Debug.Log("Hit obstacle!");
            movement.enabled = false;
        }
    }


}
