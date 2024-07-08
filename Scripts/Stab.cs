using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stab : MonoBehaviour
{
    public AudioClip sound;
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
        if (other.tag == "Player")
        {
            //BallGameManager.S.FoundGem();
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }
        //else if (other.gameObject.name == "GameOverTrigger")
        //BallGameManager.S.SetGameOver();
    }
}
