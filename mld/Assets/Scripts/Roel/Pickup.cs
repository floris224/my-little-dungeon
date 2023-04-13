using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Pickup : MonoBehaviour
{
    public GameObject doorClose;
    public GameObject doorOpen;

    public GameObject panel;
    public GameObject duck1;
    public GameObject duck2;
    public GameObject duck3;
    public GameObject duck4;
    public GameObject duck5;

    public GameObject finish;

    public Transform hand;
    public RaycastHit hit;
    public Camera fpsCam;
    public GameObject floor;
    public AudioSource duck;
    
    public TextMeshProUGUI currentPointsText;
    public TextMeshProUGUI targetPointsText;
    public int targetQuestPoints = 5;
    public int currentQuestPoints = 0;
    public int points = 1;

    
    void Update()
    {
        Finish();
        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 50f))
            {
                Gun();
                Interact();
                QuestDuck();
                
            }


        }
    }

    public void Gun()
    {
        
        if (hit.transform.tag == ("Weapon"))
        {
           hit.transform.SetParent(hand);
           hit.collider.enabled = false;
           hit.transform.position = hand.position;
           hit.transform.rotation = hand.rotation;
           hit.transform.GetComponent<Skiekten>().enabled = true;

        }


        
    }
    public void Interact()
    {
         if (hit.transform.tag == ("Interactable"))
         {
            floor.SetActive(false);
            
         }

        
       

    }
    public void QuestDuck()
    {
        if (hit.collider.CompareTag("Quest"))
        {
            duck.enabled = true;
            Destroy(hit.collider.gameObject);
            UpdatePanelCounter();
            SpawnDucky();
        }
        
    }
    
    public void UpdatePanelCounter()
    {
        currentQuestPoints += points;
        currentPointsText.text = currentQuestPoints.ToString();
        if (currentQuestPoints > targetQuestPoints)
        {
            targetPointsText.text = "(Completed)";
        }
        else
        {
            targetPointsText.text = "(" + currentQuestPoints + "/" + targetQuestPoints + ")";
        }
    }
    public void SpawnDucky()
    {
        if(currentQuestPoints == 1)
        {
            duck1.GetComponent<MeshRenderer>().enabled = true;

        }
        else if (currentQuestPoints == 2)
        {
            duck2.GetComponent<MeshRenderer>().enabled = true;
        }
        else if (currentQuestPoints == 3)
        {
            duck3.GetComponent<MeshRenderer>().enabled = true;
        }
        else if (currentQuestPoints == 4)
        {
            duck4.GetComponent<MeshRenderer>().enabled = true;
        }
        else if (currentQuestPoints == 5)
        {
            duck5.GetComponent<MeshRenderer>().enabled = true;
        }
        
       
    }
    public void Finish()
    {
        if (currentQuestPoints == 5)
        {
            doorClose.SetActive(false);
            doorOpen.SetActive(true);
            
           


        }
    }
}
