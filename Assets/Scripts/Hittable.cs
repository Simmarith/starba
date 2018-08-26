using UnityEngine;
using UnityEngine.AI;

public class Hittable : MonoBehaviour
{
    public string bulletTag;
    public float hp;
    public float armor = 1;
    public NavMeshSurface nms;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float amount)
    {
        if (this.armor != 0f)
        {
            amount = amount * this.armor;
        }
        this.hp -= amount;
        if (this.hp <= 0)
        {
            NavMeshSurface navMesh = this.GetComponentInParent<NavMeshSurface>();
            Destroy(gameObject);
            if (navMesh)
            {
                // TODO: Why doesn't this NavMesh get updated?
                nms.BuildNavMesh();
            }
        }
    }
}
