using UnityEngine;

public class BoatsCollision : MonoBehaviour
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
            //Debug.Log("Collision");
            AudioSource.PlayClipAtPoint(sound1, transform.position);
            Destroy(other.gameObject);
            RemainingLife.Instance.LoseLife();
        }
    }

}
