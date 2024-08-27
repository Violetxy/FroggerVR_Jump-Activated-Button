using UnityEngine;
using UnityEngine.SceneManagement;



public class KeyboardController : MonoBehaviour
{
    //public FrogControll frogController;
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    public float moveDistance = 1.0f;
    public float movedistance = 1.0f;
    public float jumpingheight = 1.0f;


    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Movingforward()
    {
        transform.position += Vector3.forward * moveDistance;
    }

    public void Movingbackward()
    {
        transform.position += Vector3.back * moveDistance;
    }

    public void Movingleft()
    {
        transform.position += Vector3.left * movedistance;
    }

    public void Movingright()
    {
        transform.position += Vector3.right * movedistance;
    }

    public void Jumping()
    {
        rb.AddForce(new Vector2(0f, jumpingheight), ForceMode.Impulse);
    }

    public void Attack()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        rb.velocity = transform.forward * bulletSpeed;
    }
}
