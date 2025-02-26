using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueUI : MonoBehaviour


{
    public GameObject dialogueUI;

    
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        
        {
            if (!Input.GetKeyDown(KeyCode.Escape))
            {
                dialogueUI.SetActive(true);
            }
            else { dialogueUI.SetActive(false); }
        }
    }
}
