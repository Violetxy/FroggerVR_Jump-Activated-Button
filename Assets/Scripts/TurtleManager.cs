using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TurtleManager : MonoBehaviour
{
    public float moveSpeed = 2f;

    private List<GameObject> clones = new List<GameObject>();
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ProduceTurtles", 1.0f, 10.0f);
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
    void ProduceTurtles()
    {
        Vector3 pos = transform.position;
        Quaternion roa = transform.rotation;
        GameObject turtle = Instantiate(gameObject, pos, roa);
        clones.Add(turtle);
        Destroy(turtle,50.0f);
    }
}
