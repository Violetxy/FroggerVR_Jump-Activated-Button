using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public static UIController Instance { get; private set; }
    public GameObject[] frogIcons; 
    public int totalLives = 5;

    public float maxTime = 600f; 
    private float currentTime;

    private Transform Word;
    public TextMeshPro lifeLostText;
    public TextMeshPro TimeCountDown;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentTime = maxTime;
        UpdateFrogIcons(RemainingLife.remainingLives);
        Word = transform.GetChild(0);
        lifeLostText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            //Debug.Log("Time 0!");
            SetGameOverSafely();
        }
        else
        {
            TimeCountDown.text = FormatTime(currentTime);
        }
    }
    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60F);
        int seconds = Mathf.FloorToInt(time - minutes * 60);
        return string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    private void UpdateFrogIcons(int remainingLives)
    {
        for (int i = 0; i < totalLives; i++)
        {
            if (i < remainingLives)
            {
                frogIcons[i].SetActive(true);
            }
            else
            {
                frogIcons[i].SetActive(false);
            }
        }
    }

    public void AddTime(float amount)
    {
        currentTime += amount;
        if (currentTime > maxTime)
        {
            currentTime = maxTime; 
        }
    }

    void SetGameOverSafely()
    {
        if (GameManager.S != null)
        {
            GameManager.S.SetGameOver();
        }
        else
        {
            Debug.LogError("L1Manager is not initialized.");
        }
    }

    public void ShowLifeLostMessage()
    {
        Word.gameObject.SetActive(false);
        lifeLostText.gameObject.SetActive(true);
        lifeLostText.text = "You lost a life!";
        //lifeLostText.gameObject.SetActive(false);
    }

}
