/*
 * Zach Wilson
 * Assignment 5B
 * This is the shoot with raycast scrip which gets attached to a gun and handles all of its logic for shooting
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour
{
    //functionality variables for weapon
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;

    //shot effect on objects
    public float hitForce = 10f;

    //for cosmetic potions of script
    public ParticleSystem muzzleFlash;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hitInfo;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            //throws what object you hit into the log
            Debug.Log(hitInfo.transform.gameObject.name);

            //gets the target that the raycast hit
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();

            //if the target script was found, make the target take damage
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            //apply a force onto the object that was hit by the gun
            if(hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
                //I lowkey like the following force application instead
                //hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.back) * hitForce, ForceMode.Impulse);
            }
        }
    }
}
