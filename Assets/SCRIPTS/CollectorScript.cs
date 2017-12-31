using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour {

    public int collectorAmount;
    private GameController gameController;
    private static ILogger logger = Debug.unityLogger;
    public GameObject whatToCollect;
    public GameObject collectEffect;


    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}


    void OnCollisionEnter(Collision other)
    {
        Debug.Log("OnCollisionEnter");

        //        if (other.tag == "Boundary")
        //        {
        //            return;
        //        }
        //        Instantiate(explosion, transform.position, transform.rotation);

        if (other.gameObject.tag == whatToCollect.tag)
        {

            //            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.AddAmmo(1);
            Instantiate(collectEffect, transform.position + new Vector3(0, 1, 0), transform.rotation);

            
        }
        //        Destroy(other.gameObject);
        //        Destroy(gameObject);
    }
}
