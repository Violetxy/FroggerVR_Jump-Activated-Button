using Unity.VisualScripting;
using UnityEngine;

public class SharkCollision : MonoBehaviour
{
    public AudioClip sound1;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sound1, transform.position);
            RemainingLife.Instance.LoseLife();
        }
    }

}
