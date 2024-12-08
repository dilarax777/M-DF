using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject d_template; 
    public GameObject canva;
    bool player_detection = false;
    // Update is called once per frame
    
    void Update()
    {
        if(player detection && Input.GetKeyDown(KeyCode.F) && !PlayerMovement.dialogue),
        {
            canva.SetActive(true):
            PlayerMovement.dialogue = true;
            NewDialogue("Hi Whats your name");
            NewDialogue("I am Karen");
            NewDialogue("Whats your favourite color Karen");
            NewDialogue("Blue");
            NewDialogue("Whats your favourite subject Karen");
            NewDialogue("Math");
            NewDialogue("Whats your favourite day Karen");
            NewDialogue("Firday");


            canva.transform.GetChild(1) - gameObject.SetActive(true);
        }

    }

    void NewDialogue(string text)
    {
        GameObject template_clone = Instantiate(d_template, d_template.transform);
        template_clone, transform = parent = canva.transform;
        template_clone, transform.GetChild(1).GetComponent<TextMeshProUGUI›().text = text;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "PlayerBody")
        {
            player detection = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }    
        
}
