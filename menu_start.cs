using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mode_Manager.game_mode = "Forest";
    }

    public void roam()
    {
        Mode_Manager.game_mode = "roam";
        if (map_select.map == 1) 
        {
            //Forest
            SceneManager.LoadScene("Forest");
        }
        if (map_select.map == 2)
        {
            //Circuit
            SceneManager.LoadScene("Circuit");
            
        }
        if (map_select.map == 3)
        {
            SceneManager.LoadScene("desart");
            
        }
    }
    public void race()
    {
        Mode_Manager.game_mode = "race";
        if (map_select.map == 1)
        {
            //Forest
            SceneManager.LoadScene("Forest");
        }
        if (map_select.map == 2)
        {
            //Circuit
            SceneManager.LoadScene("Circuit");

        }
        if (map_select.map == 3)
        {
            SceneManager.LoadScene("desart");

        }
    }

    public void hot()
    {
        Mode_Manager.game_mode = "hot";
        if (map_select.map == 1)
        {
            //Forest
            SceneManager.LoadScene("Forest");
        }
        if (map_select.map == 2)
        {
            //Circuit
            SceneManager.LoadScene("Circuit");

        }
        if (map_select.map == 3)
        {
            SceneManager.LoadScene("desart");

        }
    }
}
