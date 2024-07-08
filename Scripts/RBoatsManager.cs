using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RBoatsManager : MonoBehaviour
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
                clone.transform.position = new Vector3(clone.transform.position.x - moveSpeed * Time.deltaTime, clone.transform.position.y, clone.transform.position.z);
            }
        }
    }
    void ProduceBoats()
    {
        Vector3 pos = transform.position;
        Quaternion roa = boatPrefab.transform.rotation;
        pos.x -= 2.0f;
        GameObject boat = Instantiate(boatPrefab, pos, roa);
        clones.Add(boat);
        Destroy(boat,50.0f);
    }

    //void OnCollisionStay(Collision other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        other.gameObject.transform.parent = transform;
    //        AudioSource.PlayClipAtPoint(sound1, transform.position);
    //    }
    //}
    //void OnCollisionExit(Collision other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        other.gameObject.transform.parent = null;
    //    }
    //}
}
