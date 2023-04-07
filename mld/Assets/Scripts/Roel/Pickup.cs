using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform hand;
    public RaycastHit hit;
    public Camera fpsCam;
    public GameObject floor;
    
    public TextMeshProUGUI currentPointsText;
    public TextMeshProUGUI targetPointsText;
    public int targetQuestPoints = 5;
    public int currentQuestPoints = 0;
    public int points = 1;

    void Update()
    {
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
            Destroy(hit.collider.gameObject);
            UpdatePanelCounter();
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
}
