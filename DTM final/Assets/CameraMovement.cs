using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //Variables
    public Transform player;
    public Vector3 offset;
    public float speed;
    void Start()
    {

    }

   
    void Update()
    {
        //Code for the cAamera following the player
        Vector3 desiredPos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, speed * Time.deltaTime);
    }
}