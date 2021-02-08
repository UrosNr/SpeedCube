using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManagerScript gameManager;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacles"){
            movement.enabled = false;
            gameManager.GameOver();
        }
    }
}
