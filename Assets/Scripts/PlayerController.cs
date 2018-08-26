using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    public NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 travelVector = new Vector3();
        if (Input.GetKey("w"))
        {
            travelVector.z = 1;
        }
		
        if (Input.GetKey("a"))
        {
            travelVector.x = -1;
        }

        if (Input.GetKey("s"))
        {
            travelVector.z = -1;
        }

        if (Input.GetKey("d"))
        {
            travelVector.x = 1;
        }
        agent.SetDestination(transform.position + travelVector);
        this.GetComponent<Shooter>().fire = Input.GetKey("space");
    }
}
