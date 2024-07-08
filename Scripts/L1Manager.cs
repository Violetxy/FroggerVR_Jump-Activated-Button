using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState { playing, won, lost };
public class L1Manager : MonoBehaviour
{
    public static L1Manager S;
    private int totalGems;
    private int foundGems;
    private GameState gameState;

    public AudioClip sound1;
    public AudioClip sound2;

    void Awake()
    {
        S = this;
        foundGems = 0;
        gameState = GameState.playing;
        totalGems = GameObject.FindGameObjectsWithTag("Gem").Length;

        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (gameState == GameState.lost)
        {
            AudioSource.PlayClipAtPoint(sound1, transform.position);
            //SceneManager.LoadScene("LostScene", LoadSceneMode.Additive);
        }
        if (gameState == GameState.won)
        {
            AudioSource.PlayClipAtPoint(sound2, transform.position);
            //SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
        }
    }

    public void FoundGem()
    {
        foundGems++;
        if (foundGems >= totalGems)
        {

        }
    }
    public void SetGameWin()
    {
        //Time.timeScale = 5.0f;
        gameState = GameState.won;
    }
    public void SetGameOver()
    {
        //Time.timeScale = 0.0f;
        gameState = GameState.lost;
    }
}
