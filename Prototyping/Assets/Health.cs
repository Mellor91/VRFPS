using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float hitPoints = 100f;
    float currentHitPoints;

	// Use this for initialization
	void Start () {
        currentHitPoints = hitPoints;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void takeDamage(float amount)
    {
        currentHitPoints -= amount;
        Debug.Log(this.transform.name + " has " + currentHitPoints + "HP remianing");
        if (currentHitPoints <= 0) die();
    }

    void die()
    {
        Destroy(gameObject);
    }
}
