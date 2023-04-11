
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
   
    public Scene Scene;
    public GameObject panelM;
    public GameObject panelS;
    public GameObject panelL;
    public GameObject panelV;
    public GameObject panelWQ;
    public GameObject panelSounds;
    public GameObject panelWS;
    public GameObject panelLoading;
    public GameObject panelControls;

    public void Start()
    {
        Scene = SceneManager.GetActiveScene();
    }
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }
    public void QuitApp()
    {
        panelM.SetActive(false);
        panelWQ.SetActive(true);
    } 
    
    public void SettingsMenu()
    {
        panelM.SetActive(false);
        panelS.SetActive(true);
        
    }

    public void LoadMenu()
    {
        panelM.SetActive(false);
        panelL.SetActive(true);
    }
    public void SettingsVideo()
    {
        panelS.SetActive(false);
        panelV.SetActive(true);
        
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        
    }
    public void SoundSettings()
    {
        panelS.SetActive(false);
        panelSounds.SetActive(true);

    }
    public void Controls()
    {
        panelS.SetActive(false);
        panelControls.SetActive(true);
    }
    public void BackSettings()
    {
        panelS.SetActive(false);
        panelM.SetActive(true); 
    }
    public void BackVideo()
    {
        panelV.SetActive(false);
        panelS.SetActive(true);
    }
    
    public void BackSound()
    {
        panelSounds.SetActive(false);
        panelS.SetActive(true);
    }

    public void BackControl()
    {
        panelControls.SetActive(false);
        panelS.SetActive(true);
    }
    public void BackLoad()
    {
        panelL.SetActive(false);
        panelM.SetActive(true);

    }
    public void QuitAppYes()
    {
        Application.Quit();
        Debug.Log("Application has shutdown");
    }
    public void QuitAppNo()
    {
        panelWQ.SetActive(false);
        panelM.SetActive(true);
    }
  
} 
