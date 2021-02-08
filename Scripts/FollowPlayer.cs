using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;
    private void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void FixedUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
