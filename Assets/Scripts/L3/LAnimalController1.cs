using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LAnimalController : MonoBehaviour
{
    public GameObject EaglePrefab;
    public float moveSpeed = 2f;
    public float moveDistance = 20f;

    private List<GameObject> clones = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ProduceEagles", 1.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject clone in clones)
        {
            if (clone != null)
            {
                clone.transform.position = new Vector3(clone.transform.position.x + moveSpeed * Time.deltaTime, clone.transform.position.y, clone.transform.position.z);
            }
        }
    }
    void ProduceEagles()
    {
        Vector3 pos = transform.position;
        Quaternion roa = EaglePrefab.transform.rotation;
        GameObject boat = Instantiate(EaglePrefab, pos, roa);
        clones.Add(boat);
        Destroy(boat, moveDistance);
    }
}
