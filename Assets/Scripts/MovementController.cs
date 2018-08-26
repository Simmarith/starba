using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float acceleration;
    public float topSpeed;
    public float agility;
    public float inertiaDampening;
    public Transform target;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Movement stuff
    private void FixedUpdate()
    {
        if (this.target != null)
        {
            // Smoothly rotates towards target 
            this.TurnTo(this.target.position);
            // Add thrust towards target
            rb.AddRelativeForce(new Vector3(0, 0, this.acceleration));
        }
        this.DampenInertia(this.target == null);
        // cap speed at this.topSpeed
        if (rb.velocity.magnitude > this.topSpeed)
        {
            rb.velocity = rb.velocity.normalized * topSpeed;
        }
    }

    private void TurnTo(Vector3 targetPoint)
    {
        var targetRotation = Quaternion.LookRotation(targetPoint - transform.position, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, this.agility / rb.velocity.magnitude);
    }

    private void DampenInertia(bool dampenZ = false)
    {
        // Intertia dampening
        var inertiaForce = -transform.InverseTransformDirection(rb.velocity.normalized) * this.inertiaDampening;
        if (!dampenZ)
        {
            inertiaForce.z = 0;
        }
        rb.AddRelativeForce(inertiaForce);
    }
}
