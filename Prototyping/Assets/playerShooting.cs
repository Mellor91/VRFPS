using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour {

    public float fireRate = 0.5f;
    float cooldown = 0f;
    float damage = 25f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        cooldown -= Time.deltaTime;

        if (Input.GetButton("Fire1") )
        {
            fire();
        }
	}

    public void fire()
    {
        if (cooldown > 0) return;

        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Transform hitTransform;
        Vector3 hitPoint;

        hitTransform = findClosestHitObject(ray, out hitPoint);

        if(hitTransform != null)
        {
            //can do special effects for hit location
            Debug.Log("WE HIT!>>> " + hitTransform.name);

            Health h = hitTransform.GetComponent<Health>();

            if(h != null)
            {
                h.takeDamage(damage);
            }
        }

        cooldown = fireRate;
    }


    Transform findClosestHitObject(Ray ray, out Vector3 hitPoint)
    {
        RaycastHit[] hits = Physics.RaycastAll(ray);

        Transform closestHit = null;
        float distance = 0f;
        hitPoint = Vector3.zero;

        foreach(RaycastHit hit in hits)
        {
            if(hit.transform != this.transform && (closestHit == null || hit.distance < distance))
            {
                //hit something that is:
                //not the player
                //the first thing we hit, that is not the player
                // or if not the closest thing, at least closer than the previous thing
                closestHit = hit.transform;
                distance = hit.distance;
                hitPoint = hit.point;
            }
        }

        return closestHit;
    }
}
