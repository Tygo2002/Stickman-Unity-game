using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Mirror;

public class TurnOfRemotePlayer : Mirror.NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement script = this.GetComponent<PlayerMovement>();
       
        if (isLocalPlayer)
        {
            script.enabled = true;
        }
        else
        {
            //remote player 
            script.enabled = false;
        }
    }
}
