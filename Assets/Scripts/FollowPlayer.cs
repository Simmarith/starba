using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public GameObject player;
    public float offsetX;
    public float offsetY;
    public float offsetZ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + new Vector3(offsetX,offsetY,offsetZ);
        transform.LookAt(player.transform.position);
	}
}
