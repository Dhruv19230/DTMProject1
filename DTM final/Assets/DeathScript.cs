using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    //Refrences
    public GameObject startPoint;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D othern)
    {
        //if the player touches the object the plyer will be sent back to start position
     if (othern.gameObject.CompareTag("Player"))
        {
            Player.transform.position = startPoint.transform.position;
        }
    }
}
