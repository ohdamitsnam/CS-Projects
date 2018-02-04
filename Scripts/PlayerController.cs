using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.AI;

public class PlayerController : NetworkBehaviour {

    public GameObject hexagon;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        if(Input.GetMouseButtonDown(0) == hexagon)
        {
            CmdMovePlayer();
        }
    }

    [Command]
    void CmdMovePlayer()
    { 
        //var z = hexagon.transform.position;
        //gameObject.transform.Translate(0, 0, z);
    }

    // Command Indicates that the following function will be called by the client , but run on the server
    //e.g the bullet doesnt need to be sent over the network because it can be calculated from client since
    //the direction or velocity is not changed after being shot
    /*[Command]
    void CmdFire()
    {
        //create the bullet from bullet prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        //add velocity to bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        NetworkServer.Spawn(bullet);

        //destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);

    }
    */

    // Good place to do initializiation that is only for the local player,
    // such as configuring camera and input
   // public override void OnStartLocalPlayer()
   // {
    //    GetComponent<MeshRenderer>().material.color = Color.blue;
    //}
}
