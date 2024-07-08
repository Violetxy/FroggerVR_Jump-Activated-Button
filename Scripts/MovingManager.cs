using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingManager : MonoBehaviour
{
    public float moveSpeed = 2f;  
    public float moveDistance = 2f;  

    private float leftBoundary;
    private float rightBoundary;
    private bool movingLeft = true; 
    // Start is called before the first frame update
    void Start()
    {
        leftBoundary = transform.position.x - moveDistance;
        rightBoundary = transform.position.x + moveDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingLeft)
        {
            if (transform.position.x < rightBoundary)
            {
                transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                movingLeft = false;
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
                movingLeft = true;
            }
        }
    }
}
