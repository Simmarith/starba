using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    public NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            agent.SetDestination(transform.position + new Vector3(0,0,1));
        }
		
        if (Input.GetKey("a"))
        {
            agent.SetDestination(transform.position + new Vector3(-1,0,0));
        }

        if (Input.GetKey("s"))
        {
            agent.SetDestination(transform.position + new Vector3(0,0,-1));
        }

        if (Input.GetKey("d"))
        {
            agent.SetDestination(transform.position + new Vector3(1,0,0));
        }
	}
}
