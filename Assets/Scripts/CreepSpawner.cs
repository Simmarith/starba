using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepSpawner : MonoBehaviour {

    public GameObject creep;
    public GameObject target;
    public float spawnSpread;

    private List<GameObject> creeps = new List<GameObject>();

	// Use this for initialization
	void Start () {
        this.SpawnWave();
        this.Target(this.target);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SpawnWave()
    {
        for (var i = 0; i < 50; i++) {
            var newCreep = Instantiate(
                this.creep,
                transform.position +
                new Vector3(
                    Random.Range(0f, this.spawnSpread),
                    Random.Range(0f, this.spawnSpread),
                    Random.Range(0f, this.spawnSpread)
                    ),
                transform.rotation
                );
            Debug.Log(newCreep);
            this.creeps.Add(newCreep);
        }
    }

    public void Target(GameObject target) {
        foreach (var thisCreep in this.creeps)
        {
            thisCreep.GetComponent<MovementController>().target = target.transform;
        }
    }

}
