using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Code for when player touches the black object load level 2
    private void OnCollisionEnter2D(Collision2D other)
    {
      if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("level2");
        }  
    }
}
