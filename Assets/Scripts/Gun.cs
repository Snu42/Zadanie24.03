using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public Rigidbody Bullet;
    public Transform FirePlace;
    private Rigidbody projectile;
    public float power;

    private bool fire;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            projectile = Instantiate(Bullet, FirePlace.position, transform.rotation);
            fire = true;
        }
        
    }
    private void FixedUpdate()
    {
        if (fire)
        {
            projectile.velocity = transform.TransformDirection(Vector3.right * power);
            fire = false;
            Destroy(projectile.gameObject, 3);
        }
    }
}
