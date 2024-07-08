using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spider : MonoBehaviour
{
    public float moveSpeed = 2f;  // ֩����ƶ��ٶ�
    public float moveDistance = 0.8f;  // ֩���ƶ���������

    private float leftBoundary;
    private float rightBoundary;
    private bool movingRight = true;  // ��ʼ��������

    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        leftBoundary = transform.position.x - moveDistance;
        rightBoundary = transform.position.x + moveDistance;

        m_Animator = GetComponent<Animator>();
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
}
