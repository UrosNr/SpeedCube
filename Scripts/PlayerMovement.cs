using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public Rigidbody rigid;
    public GameManagerScript gameManager;
    public float ForwardForce = 2000f;
    public float SideForce = 500f;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        //add force
        rigid.AddForce(0, 0, ForwardForce * Time.deltaTime);
        
        if (Input.GetKey("a"))
        {
            rigid.AddForce(-SideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rigid.AddForce(SideForce* Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (rigid.position.y < -1f)
        {
            gameManager.GameOver();
        }

    }

}

