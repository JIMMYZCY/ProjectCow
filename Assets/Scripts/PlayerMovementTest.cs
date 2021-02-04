using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerMovementTest : NetworkBehaviour
{
    [SerializeField]
    public float moveSpeed = 10;

    private void Update()
    {
        if(!isLocalPlayer) { return; }
        PlayerMove();
    }

    private void PlayerMove()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal * moveSpeed, 0, moveVertical * moveSpeed);
        transform.position = transform.position + movement;
    }
}


