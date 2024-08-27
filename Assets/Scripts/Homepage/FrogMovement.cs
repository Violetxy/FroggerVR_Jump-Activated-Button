using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogMovement : MonoBehaviour
{
    public float moveStep = 0.1f; // ÿ֡�ƶ��Ĳ���
    public float frameRate = 0.1f; // ÿ֡��ʱ�������룩
    public float lifeTime = 20f;

    private Vector2 direction = Vector2.up;

    private float timer = 0f;

    public GameObject frogPrefab; // ���ܵ�Ԥ����

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

            // ������ܵ�����
            if (timer >= lifeTime)
            {
                // �����µ�����
                SpawnNewFrog();
                // ���ٵ�ǰ����
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
