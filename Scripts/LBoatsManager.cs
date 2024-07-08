using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LBoatsManager : MonoBehaviour
{
    public GameObject boatPrefab;
    public float moveSpeed = 2f;

    private List<GameObject> clones = new List<GameObject>();
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ProduceBoats", 1.0f, 10.0f);
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
    void ProduceBoats()
    {
        Vector3 pos = boatPrefab.transform.position;
        Quaternion roa = boatPrefab.transform.rotation;
        GameObject boat = Instantiate(boatPrefab, pos, roa);
        clones.Add(boat);
        Destroy(boat,50.0f);
    }
}
