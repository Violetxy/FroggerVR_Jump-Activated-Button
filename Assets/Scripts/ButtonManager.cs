using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    public GameObject button6;

    public GameObject rule;
    // Start is called before the first frame update
    void Start()
    {
        rule.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitButton()
    {
        UnityEngine.Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    public void ClickRuleButton()
    {
        rule.gameObject.SetActive(true);
        button6.gameObject.SetActive(true);
    }

    public void level1load()
    {
        SceneManager.LoadScene(1);
    }
    public void level2load()
    {
        SceneManager.LoadScene(2);
    }
    public void level3load()
    {
        SceneManager.LoadScene(3);
    }
    public void CloseButton()
    {
        button6.gameObject.SetActive(false);
        rule.gameObject.SetActive(false);
    }
    public void ReturnButton()
    {
        SceneManager.LoadScene(0);
    }
}
