using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerMovementTest : NetworkBehaviour
{
    public float moveSpeed = 10;

    [SyncVar]
    public bool isDead = false;

    [SyncVar]
    public bool isRespawned = false;

    public MeshRenderer player_MeshRenderer;
    public MeshRenderer DeadBody_MeshRenderer;
    public GameObject Respawn_Point;
    public GameObject Deadbody;

    public float rotationspeed = 100.0f;

    private void Update()
    {
        if (isDead == false)
        {
            PlayerMove();
        }

        if (isDead == true)
        {
            PlayerDead();
        }

        if (isRespawned == true && isDead == true)
        {
            PlayerRespawn();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Killer")
        {
            isDead = true;
        }
    }

    private void PlayerMove()
    {
        /*        if (!isLocalPlayer) return;

                float moveHorizontal = Input.GetAxis("Horizontal");
                float moveVertical = Input.GetAxis("Vertical");
                Vector3 movement = new Vector3(moveHorizontal * moveSpeed, 0, moveVertical * moveSpeed);
                transform.position = transform.position + movement;*/

        if (!isLocalPlayer) return;

        float vertical = Input.GetAxis("Vertical") * moveSpeed;
        float horizontal = Input.GetAxis("Horizontal") * rotationspeed;

        vertical *= Time.deltaTime;
        horizontal *= Time.deltaTime;
        transform.Translate(0, 0, vertical);
        transform.Rotate(0, horizontal, 0);
    }


    private void PlayerDead()
    {
        if (!isDead) return;

        player_MeshRenderer.enabled = false;
        DeadBody_MeshRenderer.enabled = true;
    }
    

    private void PlayerRespawn()
    {
        if (isRespawned == true && isDead == true)
        {
            isDead = false;
            isRespawned = false;
            gameObject.transform.position = Respawn_Point.transform.position;
            player_MeshRenderer.enabled = true;
            DeadBody_MeshRenderer.enabled = false;
        }
    }
}


