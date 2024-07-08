using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogMovement : MonoBehaviour
{
    //public float speed = 2f; // 移动速度
    //public float pauseDuration = 0.5f; // 每个点的停顿时间
    //private Vector2[] points; // 移动路径点
    //private int currentPoint = 0; // 当前目标点的索引
    //private bool isMoving = true; // 是否在移动

    //public Transform target; // 要围绕的目标对象
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
    //            // 获取当前点的位置
    //            Vector2 targetPosition = path[currentPoint];

    //            // 移动青蛙到目标点
    //            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

    //            // 如果青蛙到达了目标点，更新到下一个点
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
