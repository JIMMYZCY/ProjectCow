using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Check_Death : NetworkBehaviour
{
    // Start is called before the first frame update
    public bool player_death = false;
    public bool player_respawn = false;
    public MeshRenderer player_MeshRenderer;
    public MeshRenderer DeadBody_MeshRenderer;
    public GameObject Respawn_Point;
    public GameObject Deadbody;
    void Start()
    {
        player_MeshRenderer = GetComponent<MeshRenderer>();
        DeadBody_MeshRenderer = Deadbody.GetComponent<MeshRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (player_death == true)
        {

            dead();

        }
        if (player_respawn == true&&player_death == true)
        {
            Respawn();
        }
    }

    private void dead()
    {
        player_MeshRenderer.enabled = false;
        DeadBody_MeshRenderer.enabled = true;
        

    }

    private void Respawn()
    {
        player_death = false;
        player_respawn = false;
        gameObject.transform.position = Respawn_Point.transform.position;
        player_MeshRenderer.enabled = true;
        DeadBody_MeshRenderer.enabled = false;

    }
}
