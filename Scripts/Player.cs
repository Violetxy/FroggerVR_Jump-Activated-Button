using OVR;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    Animator m_Animator;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    AudioSource Sound;

    public Transform sparkle1;
    public Transform sparkle2;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody=GetComponent<Rigidbody>();
        Sound = transform.GetComponent<AudioSource>();
        Sound.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Spider"))
        {
            Vector3 contactPoint = other.ClosestPoint(transform.position);
            float playerYVelocity = playerRigidbody.velocity.y;
            m_Animator = other.gameObject.GetComponent<Animator>();

            // ºÏ≤È «∑Ò¥”…œ∑Ω≤»µΩ÷©÷Î
            if (playerYVelocity < 0 && transform.position.y > contactPoint.y)
            {
                // ≤»À¿÷©÷Î¬ﬂº≠
                Debug.Log("Spider die");
                Destroy(other.gameObject);
                m_Animator.SetInteger("isdoing", 2);
                AudioSource.PlayClipAtPoint(sound1, transform.position);
            }
            else
            {
                L1Manager.S.SetGameOver();
            }
        }
        else if (other.tag == "Gem")
        {
            //L1Manager.S.FoundGem();
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(sound2, transform.position);
            Instantiate(sparkle1, other.gameObject.transform.position, other.gameObject.transform.rotation);
        }
        else if (other.tag == "death")
        {
            L1Manager.S.SetGameOver();
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Boats"))
        {
            transform.parent = other.gameObject.transform;
            Sound.enabled = true;
        }
        else if (other.gameObject.CompareTag("exit"))
        {
            Instantiate(sparkle2, transform.position, transform.rotation);
            L1Manager.S.SetGameWin();
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Boats"))
        {
            transform.parent = null;
            Sound.enabled = false;
        }
    }
}
