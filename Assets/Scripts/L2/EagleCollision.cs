using Unity.VisualScripting;
using UnityEngine;

public class EagleCollision : MonoBehaviour
{
    Animator m_Animator;

    public AudioClip sound1;
    public AudioClip sound2;

    public Transform explosionParticle;


    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            m_Animator.SetBool("isAttacking", true);
            AudioSource.PlayClipAtPoint(sound1, transform.position);
            RemainingLife.Instance.LoseLife();
        }
        else if (other.gameObject.CompareTag("Bullet"))
        {
            AudioSource.PlayClipAtPoint(sound2, transform.position);
            Transform clone = Instantiate(explosionParticle, transform.position, transform.rotation);
            Destroy(clone.gameObject, 1f);
            m_Animator.SetBool("isDead", true);
            Destroy(gameObject);
        }
    }

}
