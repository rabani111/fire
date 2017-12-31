using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name!="Plane")
                Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
