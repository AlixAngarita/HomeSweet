using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int vidaTotal = 140;
    //bool running = true;
     private float nextActionTime = 0.0f;
    public float period = 1f;
    public GameObject player;
    private Animator m_Animator;
    public GameObject PausePanel;
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        if(PausePanel != null)
        {
            PausePanel.SetActive(false);
            GameOverPanel.SetActive(false);
        }
        m_Animator = player.GetComponent<Animator>();
        //PlayerPrefs.SetInt("Vida", 40);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            /*Time.timeScale = running ? 0 : 1;
            running = !running;*/
            PauseGame();
        }

        if (Time.time > nextActionTime ) {
            nextActionTime += period;
            // execute block of code here
            vidaTotal-=2;
        }

        if(vidaTotal <= 0)
        {
            GameOver();
        }  
    }

    public void sumarFrutas(int valorFruta)
    {
        vidaTotal += valorFruta; 
        Debug.Log(vidaTotal);
    }

    public int getVidaTotal()
    {
        return vidaTotal;
    }

    public void StartGame()
    {
        if(PausePanel != null)
        {
            PausePanel.SetActive(false);
            GameOverPanel.SetActive(false);
        }
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        m_Animator = player.GetComponent<Animator>();
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        //running = false;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        //running = true;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        m_Animator.SetTrigger("Golpe Mortal");
        GameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
}