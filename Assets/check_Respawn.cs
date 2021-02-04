using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class check_Respawn : NetworkBehaviour
{
    // Start is called before the first frame update
    
    private GameObject Target_Player;
    public GameObject Respawn_Point;
    public bool Test_bool = false;
    void Start()
    {
        Target_Player = GameObject.Find("local player");
    }

    // Update is called once per frame
    void Update()
    { 
         if( Test_bool == true )
        {
            

            Cmd_Respawn(Target_Player);

            ;

        }
    }

   [Command]
   private void Cmd_Respawn(GameObject Target)
    {
        NetworkIdentity playerIdentity = Target.GetComponent<NetworkIdentity>();
        Target_Respond(playerIdentity.connectionToClient);
        

    }

    [TargetRpc]
    public void Target_Respond(NetworkConnection Target)
    {
        Debug.Log("Wuhu");
        Target_Player.SetActive(true);
        Target_Player.GetComponent<Check_Death>().player_death = false;
    }
}
