using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public int scoreValue;
    private GameController gameController;
    private static ILogger logger = Debug.unityLogger;

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

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("OnCollisionEnter");

        //        if (other.tag == "Boundary")
        //        {
        //            return;
        //        }
        //        Instantiate(explosion, transform.position, transform.rotation);

        if (other.gameObject.name == "waterParticle(Clone)")
        {

            //            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.AddScore(scoreValue);

        }
        //        Destroy(other.gameObject);
        //        Destroy(gameObject);
    }
}