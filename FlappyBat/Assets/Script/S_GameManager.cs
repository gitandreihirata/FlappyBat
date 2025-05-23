using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class S_GameManager : MonoBehaviour
{
    public GameObject startButton;
    public S_Player player;
    public Text gameOverCountdown;
    public float countTimer = 5;
    // Start is called before the first frame update
    void Start()
    {
        gameOverCountdown.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
    private void Update()
    {
        if( player.isDead )
        {
        gameOverCountdown.gameObject.SetActive(true);
        countTimer -= Time.unscaledDeltaTime;
        }
 
        gameOverCountdown.text = "Restarting in " + (countTimer).ToString("0");
        if (countTimer < 0)
        {
            RestartGame();
        }
        
    }
    public void StartGame()
    {
        startButton.SetActive(false);
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        Time.timeScale = 0;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
