using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform gunNozzle;
    public float fireRate;
    public bool fire;

    private float fireCountdown = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.fire)
        {
            if (this.fireCountdown <= 0f)
            {
                this.Shoot();
                fireCountdown = 1f / this.fireRate;
            }
        }
        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        GameObject newBullet = (GameObject)Instantiate(this.bullet, this.gunNozzle.position, this.gunNozzle.rotation);
        Bullet bulletScript = newBullet.GetComponent<Bullet>();

        if (bulletScript != null)
        {
            bulletScript.Fly(transform.rotation);
        }
    }
}
