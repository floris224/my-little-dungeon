using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public int health;
    public Transform[] enemy;
    public GameObject defeat;
    
    //playerPref is dat de data wordt opgeslagen op de computer inplaats van op de cloud daarom is dit niet veilig

    public void Start()
    {
        
    }

    public void SavePlayer(int i)
    {
        PlayerPrefs.SetFloat(i.ToString() + "PlayerX", transform.position.x);
        PlayerPrefs.SetFloat(i.ToString() + "PlayerY", transform.position.y);
        PlayerPrefs.SetFloat(i.ToString() + "PlayerZ", transform.position.z);

        PlayerPrefs.SetInt(i.ToString() + "PlayerHealth", health);

        SaveEnemies(i);

        Debug.Log("Saved");
    }

    private void SaveEnemies(int i)
    {
        //hier word een loop gebruikt met als index het variabele j
        for (int j = 0; j < enemy.Length; j++)
        {
            PlayerPrefs.SetFloat(i.ToString() + "Enemy" + j.ToString() + "X", enemy[j].position.x);
            PlayerPrefs.SetFloat(i.ToString() + "Enemy" + j.ToString() + "Y", enemy[j].position.y);
            PlayerPrefs.SetFloat(i.ToString() + "Enemy" + j.ToString() + "Z", enemy[j].position.z);
        }
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
        // hier wordt een loop gebruikt waarbij alle enemys in de array doorgelopen wordt en de loadenemy aanroept met de variabelen i en j
        for (int j = 0; j < enemy.Length; j++) { 
            LoadEnemy(i, j);
        }

        Debug.Log("loaded");
    }
    // hier wordt de positie van de enemy  geladen  en wordt de variablen J ingesteld als de nieuwe positie van de enemies
    public void LoadEnemy(int i, int j)
    {
        Vector3 enemyPos = new Vector3(
            PlayerPrefs.GetFloat(i.ToString() + "Enemy" + j.ToString() + "X"),
            PlayerPrefs.GetFloat(i.ToString() + "Enemy" + j.ToString() + "Y"),
            PlayerPrefs.GetFloat(i.ToString() + "Enemy" + j.ToString() + "Z")
            );
        enemy[j].position = enemyPos;
    }
    public void Death()
    {
        if (health == 0)
        {
            Time.timeScale = 0;
            defeat.SetActive(true);
           
        }
    }
}
