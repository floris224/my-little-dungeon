using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Panel : MonoBehaviour
{
    public TextMeshProUGUI currentPointsText;
    public TextMeshProUGUI targetPointsText;
    public int targetQuestPoints = 5;
    public int currentQuestPoints = 0;
    public RaycastHit hit;
    public int points = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10) && hit.collider.CompareTag("Quest") && Input.GetKey(KeyCode.E))
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