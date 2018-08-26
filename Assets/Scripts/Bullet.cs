using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float damage;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fly(Quaternion direction)
    {
        transform.rotation = direction;
        rb.AddRelativeForce(new Vector3(0, 0, this.speed));
    }


    private void OnCollisionEnter(Collision collision)
    {
        Hittable hit = collision.gameObject.GetComponent<Hittable>();
        if (hit != null)
        {
            hit.TakeDamage(this.damage);
        }
        Destroy(gameObject);
    }
}
