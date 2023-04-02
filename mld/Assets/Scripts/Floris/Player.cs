using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
   //playerPref is dat de data wordt opgeslagen op de computer inplaats van op de cloud daarom is dit niet veilig
   
    public void SavePlayer(int i)
    {
        PlayerPrefs.SetFloat(i.ToString() + "PlayerX", transform.position.x);
        PlayerPrefs.SetFloat(i.ToString() + "PlayerY", transform.position.y);
        PlayerPrefs.SetFloat(i.ToString() + "PlayerZ", transform.position.z);

        PlayerPrefs.SetInt(i.ToString() + "PlayerHealth", health);

        Debug.Log("Saved");
    }

    public void LoadPlayer(int i)
    {
        Vector3 position = new Vector3
         (
            PlayerPrefs.GetFloat(i.ToString() + "PlayerX"),
            PlayerPrefs.GetFloat(i.ToString() + "PlayerY"),
            PlayerPrefs.GetFloat(i.ToString() + "PlayerZ")

        
         );
        transform.position = position;
        health = PlayerPrefs.GetInt(i.ToString() + "PlayerHealth");
        Debug.Log("loaded");
    }
}
