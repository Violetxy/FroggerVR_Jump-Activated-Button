using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogMovement : MonoBehaviour
{
    //public float speed = 2f; // �ƶ��ٶ�
    //public float pauseDuration = 0.5f; // ÿ�����ͣ��ʱ��
    //private Vector2[] points; // �ƶ�·����
    //private int currentPoint = 0; // ��ǰĿ��������
    //private bool isMoving = true; // �Ƿ����ƶ�

    //public Transform target; // ҪΧ�Ƶ�Ŀ�����
    // Start is called before the first frame update
    void Start()
    {
        //float halfWidth = target.GetComponent<Renderer>().bounds.size.x / 2;
        //float halfHeight = target.GetComponent<Renderer>().bounds.size.y / 2;
        //points = new Vector2[4];
        //points[0] = new Vector2(-halfWidth, halfHeight);
        //points[1] = new Vector2(halfWidth, halfHeight);
        //points[2] = new Vector2(halfWidth, -halfHeight);
        //points[3] = new Vector2(-halfWidth, -halfHeight);

        //transform.position = points[0];
    }

    void Update()
    {
        //Vector2 targetPosition = points[currentPoint];

        //transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        //if ((Vector2)transform.position == targetPosition)
        //{
        //    currentPoint = (currentPoint + 1) % points.Length;
        //}
    }

    // Update is called once per frame
    //IEnumerator MoveToNextPoint()
    //{
    //    while (true)
    //    {
    //        if (isMoving)
    //        {
    //            // ��ȡ��ǰ���λ��
    //            Vector2 targetPosition = path[currentPoint];

    //            // �ƶ����ܵ�Ŀ���
    //            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

    //            // ������ܵ�����Ŀ��㣬���µ���һ����
    //            if ((Vector2)transform.position == targetPosition)
    //            {
    //                isMoving = false;
    //                currentPoint = (currentPoint + 1) % path.Length;
    //                //yield return new WaitForSeconds(pauseDuration);
    //                isMoving = true;
    //            }
    //        }

    //        yield return null;
    //    }
    //}
}
