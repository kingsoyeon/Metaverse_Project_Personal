using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                SceneManager.LoadScene("HouseScene");
            }
            else if (SceneManager.GetActiveScene().name == "HouseScene")
              {
            SceneManager.LoadScene("SampleScene");
        
        }
    }
}
