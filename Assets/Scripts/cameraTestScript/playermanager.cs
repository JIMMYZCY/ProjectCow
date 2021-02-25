using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : NetworkBehaviour
{
    //public string pname = "player";

    /*void OnGUI()
    {
        name = GUI.TextField(new Rect(25, Screen.height - 40, 100, 30), pname);

    }*/


    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<movement>().enabled = true;
            /*Camera.main.transform.position = this.transform.position - this.transform.forward * 8f + this.transform.up * 5f;
            Camera.main.transform.LookAt(this.transform.position);
            Camera.main.transform.parent = this.transform;*/
        }
    }
    /*void Update()
    {
        if (isLocalPlayer)
        {
            this.GetComponentInChildren<TextMesh>().text = pname;
        }
    }*/
}
