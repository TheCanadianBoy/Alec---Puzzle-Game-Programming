using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public GameObject winText;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject singleton = new GameObject();
                    singleton.AddComponent<GameManager>();
                    singleton.name = "(Singleton) GameManager";
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
    }

    //When the player touches the Golden Box, we want to activate the Text saying "You win!" and stop the game
    public void OnWin()
    {
        winText.SetActive(true);
        Time.timeScale = 0;
    }

}
