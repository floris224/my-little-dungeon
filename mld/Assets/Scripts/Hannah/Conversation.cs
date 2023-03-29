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


    void Start()
    {
        conversationIndex = 0; 
    }

   
    void Update()
    {
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
