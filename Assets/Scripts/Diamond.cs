using UnityEngine;

public class Diamond : MonoBehaviour
{
    public AudioClip sound;
    public Transform sparkle;
    public GameObject timeBonusTextPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UIController uiController = FindObjectOfType<UIController>();
            if (uiController != null)
            {
                uiController.AddTime(10f); 
            }
            AudioSource.PlayClipAtPoint(sound, transform.position);
            Instantiate(sparkle, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(sparkle, 5);
            ShowTimeBonusText();
        }
    }
    private void ShowTimeBonusText()
    {
        GameObject textObject = Instantiate(timeBonusTextPrefab, transform.position, Quaternion.identity);
    }
}
