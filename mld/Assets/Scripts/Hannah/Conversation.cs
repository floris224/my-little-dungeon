using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour
{
    public Text conversation;
    public float range;
    public int conversationIndex;
    public Transform phone; 

     
    void Start()
    {
        conversationIndex = 0; 
    }

   
    void Update()
    {

       
            float distance = Vector3.Distance(phone.position, transform.position);
        if (distance < 5)
        {
           
        }
       

        conversation.text = "test text";
        if (Input.GetKeyUp(KeyCode.Space))
        {
            conversationIndex++;
            UpdateConversation();

        }   
    }

    public void UpdateConversation()
    {
        switch (conversationIndex)
        {
            case 0:
                conversation.text = "biep boep";
                break;
        }
    }
}
