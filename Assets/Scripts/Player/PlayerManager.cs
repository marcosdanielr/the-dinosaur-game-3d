using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool isGameOver;
    public GameObject gameOverPanel;

    private void Awake()
    {
        isGameOver = false;        
    }

    void Start()
    {
              
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            gameOverPanel.SetActive(true);
        }       
    }

    /*public void ReplayLevel1() 
    {
        SceneManager.LoadScene(SceneManager.GetAtiveScene().buildIndex); 
    }*/
}