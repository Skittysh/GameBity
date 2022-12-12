using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform player;
    public Transform player2;
    public Vector3 offset;
    


    void Update()
    {
        transform.position = new Vector3((player.position.x + player2.position.x) / 2 + offset.x , (player.position.y + player2.position.y) / 2 + offset.y, transform.position.z);

    }
}
