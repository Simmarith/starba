using UnityEngine;
using UnityEngine.AI;

public class CreepManager : MonoBehaviour
{
    public GameObject target;

    public NavMeshAgent agent;
    public GameObject Target
    {
        get
        {
            return this.target;
        }

        set
        {
            this.target = value;
            if (value != null)
            {
                this.agent.SetDestination(value.transform.position);
            }
        }
    }

    // Use this for initialization
    void Start()
    {
        if (this.target != null)
        {
            this.agent.SetDestination(this.target.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
