using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGenerator : MonoBehaviour {

    private static ILogger logger = Debug.unityLogger;

    public GameObject objectTypeToSpawn;
    public GameObject plain;
    public GameObject generationEffect;
    public int generationInterval = 2;
    private Vector3 plainSize;
    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnNewObject());
        plainSize = plain.GetComponent<Collider>().bounds.size;

    }

    // Update is called once per frame
    void Update () {
		
	}
 
// drop a gameObject (preferably a prefab) here in the inspector
 


    // call this function whenever you want to spawn a new object at a random position

    public IEnumerator SpawnNewObject()
    {
        while (true){ 
        yield return new WaitForSeconds(generationInterval);

            logger.Log("plainSize " + plainSize);
        Vector3 theNewPos = new Vector3(Random.Range(0, plainSize.x/2), 0, Random.Range(0, plainSize.z/2));
            if (generationEffect != null)
            {
                Instantiate(generationEffect, theNewPos, transform.rotation);
            }
            Instantiate(objectTypeToSpawn, theNewPos, transform.rotation);
        }

        // do any other stuff with newObject here...

    }




}
