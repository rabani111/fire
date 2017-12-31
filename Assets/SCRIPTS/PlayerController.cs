using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : MonoBehaviour //NetworkBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    private GameController gameController;

    void Update()
    {
        /*
                if (!isLocalPlayer)
                {
                    return;
                }
                */
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

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
    void Fire()
    {
        if (gameController.getAmmo() > 0) {

            gameController.AddAmmo(-1);
            // Create the Bullet from the Bullet Prefab
            var bullet = (GameObject)Instantiate(
                bulletPrefab,
                bulletSpawn.position + new Vector3(0,1,0),
                bulletSpawn.rotation);

            // Add velocity to the bullet
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 16;

            // Destroy the bullet after 2 seconds
            Destroy(bullet, 2.0f);

        }

    }
    /*
    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
    */
}