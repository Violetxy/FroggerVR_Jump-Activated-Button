using UnityEngine;

public class MushroomController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveDistance = 2f;
    public float jumpingheight = 1.0f;

    private float leftBoundary;
    private float rightBoundary;
    private bool movingRight = true;
    private Rigidbody rb;

    public AudioClip sound1;
    public AudioClip sound2;

    public Transform explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        leftBoundary = transform.position.x - moveDistance;
        rightBoundary = transform.position.x + moveDistance;

        rb = transform.GetComponent<Rigidbody>();

        InvokeRepeating("Jump", 1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            if (transform.position.x < rightBoundary)
            {
                transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z );
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
                transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z );
            }
            else
            {
                movingRight = true;
            }
        }
    }

    private void Jump()
    {
        rb.AddForce(new Vector2(0f, jumpingheight), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sound1, transform.position);
            RemainingLife.Instance.LoseLife();
        }
        else if (other.gameObject.CompareTag("Bullet"))
        {
            AudioSource.PlayClipAtPoint(sound2, transform.position);
            Transform clone = Instantiate(explosionParticle, transform.position, transform.rotation);
            Destroy(clone.gameObject, 1f);
            Destroy(gameObject);
        }
    }
}
