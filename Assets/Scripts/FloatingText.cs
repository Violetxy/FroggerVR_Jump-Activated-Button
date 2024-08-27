using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloatingText : MonoBehaviour
{
    public float floatSpeed = 1f;
    public float fadeDuration = 1.5f;

    private TextMeshPro textMesh;
    private Color originalColor;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
        originalColor = textMesh.color;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * floatSpeed * Time.deltaTime;

        float alpha = Mathf.Lerp(originalColor.a, 0, Time.time / fadeDuration);
        textMesh.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);

        if (textMesh.color.a <= 0)
        {
            Destroy(gameObject);
        }
    }
}
