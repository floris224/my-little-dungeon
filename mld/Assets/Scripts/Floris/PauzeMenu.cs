using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauzeMenu : MonoBehaviour
{
    public GameObject panelP;
    public GameObject panelS;
    public GameObject panelL;
    public bool isActive;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isActive)
            {
                CloseMenu();
            }
            else
            {
                PauzeGame();
            }
            
        }
    }
    
    public void PauzeGame()
    {

        panelP.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        isActive = true;
    }
    public void CloseMenu()
    {
        panelP.SetActive(false);
        panelS.SetActive(false);
        panelL.SetActive(false);
        
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        isActive = false;
    }
    public void BackP()
    {
        panelP.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        isActive = false;
    }
    public void SaveSys()
    {
       panelP.SetActive(false);
       panelS.SetActive(true);
       Time.timeScale = 0f;
    }
    public void LoadSys()
    {
        panelP.SetActive(false);
        panelL.SetActive(true);
        Time.timeScale = 0f;
    }
    public void BackSave()
    {
        panelS.SetActive(false);
        panelP.SetActive(true);
        isActive = true;
        

    }
    public void BackLoad()
    {
        panelL.SetActive(false);
        panelP.SetActive(true);
        isActive = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
