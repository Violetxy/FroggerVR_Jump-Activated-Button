using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RMoving : MonoBehaviour
{
    public float moveSpeed = 2f;  
    public float moveDistance = 2f;  

    private float leftBoundary;
    private float rightBoundary;
    private bool movingRight = true;

    public AudioClip sound1;
    // Start is called before the first frame update
    void Start()
    {
        leftBoundary = transform.position.x - moveDistance;
        rightBoundary = transform.position.x + moveDistance;

    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            if (transform.position.x < rightBoundary)
            {
                transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                movingRight = false;
            }
        }
        else
        {
            if (transform.position.x > leftBoundary)
            {
                transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                movingRight = true;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sound1, transform.position);
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.parent = transform;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.parent = null;
        }
    }
}
