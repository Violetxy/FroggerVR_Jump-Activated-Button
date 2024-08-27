using UnityEngine;

public enum GameState { playing, won, lost };
public class GameManager : MonoBehaviour
{
    public static GameManager S;
    private GameState gameState;

    public AudioClip failure;
    public AudioClip win;

    public GameObject Failuretip;
    public GameObject Wintip;
    public GameObject Keyboard;

    void Awake()
    {
        S = this;
        gameState = GameState.playing;
        Failuretip.gameObject.SetActive(false);
        Wintip.SetActive(false);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState == GameState.lost)
        {
            UIController.Instance.lifeLostText.text = "Game Over";
            Failuretip.gameObject.SetActive(true);
            Keyboard.SetActive(false);
            //Debug.Log("No more lives!");
        }
        if (gameState == GameState.won)
        {
            UIController.Instance.lifeLostText.text = "Congratulations! You can enter into next level.";
            AudioSource.PlayClipAtPoint(win, transform.position);
            Wintip.SetActive(true);
        }
    }

    public void SetGameWin()
    {
        //Time.timeScale = 1.0f;
        gameState = GameState.won;
    }
    public void SetGameOver()
    {
        //Time.timeScale = 0.0f;
        gameState = GameState.lost;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            RemainingLife.Instance.LoseLife();
        }
    }
}
