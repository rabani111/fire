using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviourScript : MonoBehaviour {

    private static ILogger logger = Debug.unityLogger;

    public GameObject dieEffectsPrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void  Die()
    {        
        Instantiate(dieEffectsPrefab, transform.position + new Vector3(0,1,0), transform.rotation);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision col)
    {
        logger.Log(this.gameObject.name + " got hit with " + col.gameObject.name);
        if (col.gameObject.name == "waterParticle(Clone)")
        {
            Destroy(col.gameObject);
            Die();
        }
    }

}
