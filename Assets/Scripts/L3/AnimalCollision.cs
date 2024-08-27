using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalCollision : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;

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
        else if (other.gameObject.CompareTag("Bullet"))
        {
            AudioSource.PlayClipAtPoint(sound2, transform.position);
            RemainingLife.Instance.LoseLife();
            Destroy(gameObject);
        }
    }

}
