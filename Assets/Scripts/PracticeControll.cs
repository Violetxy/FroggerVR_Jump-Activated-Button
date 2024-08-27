using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class PracticeControll : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public AudioClip sound;
    public float displayTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Judge()
    {
        StartCoroutine(ShowImage());
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }

    IEnumerator ShowImage()
    {
        textMeshPro.gameObject.SetActive(true);
        yield return new WaitForSeconds(displayTime);
        textMeshPro.gameObject.SetActive(false);
    }
}
