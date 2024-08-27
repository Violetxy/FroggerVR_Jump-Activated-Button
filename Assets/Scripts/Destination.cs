using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destination : MonoBehaviour
{
    public GameObject sparkle;
    public AudioClip sound;

    public float scale = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject particle = Instantiate(sparkle, transform.position, transform.rotation);
        particle.transform.localScale = new Vector3(scale, scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            GameManager.S.SetGameWin();
        }
    }
}
