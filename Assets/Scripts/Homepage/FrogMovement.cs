using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogMovement : MonoBehaviour
{
    public float moveStep = 0.1f; // 每帧移动的步长
    public float frameRate = 0.1f; // 每帧的时间间隔（秒）
    public float lifeTime = 20f;

    private Vector2 direction = Vector2.up;

    private float timer = 0f;

    public GameObject frogPrefab; // 青蛙的预制体

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveFrog());
    }

    void Update()
    {

    }

    private IEnumerator MoveFrog()
    {
        while (true)
        {
            //Debug.Log("Moving frog: " + transform.position);
            transform.Translate(direction * moveStep);
            timer += frameRate;

            // 检查青蛙的寿命
            if (timer >= lifeTime)
            {
                // 创建新的青蛙
                SpawnNewFrog();
                // 销毁当前青蛙
                Destroy(gameObject);
                yield break;
            }
            yield return new WaitForSeconds(frameRate);
        }
    }

    private void SpawnNewFrog()
    {
        Quaternion currentRotation = transform.rotation;
        GameObject newFrog = Instantiate(frogPrefab, transform.position, currentRotation * Quaternion.Euler(0,0,180));
    }
}
