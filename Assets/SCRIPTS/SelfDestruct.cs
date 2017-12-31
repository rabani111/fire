using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SelfDestruct : MonoBehaviour {
    public int detroyIn;
    private static ILogger logger = Debug.unityLogger;
    public GameObject dieEffectsPrefab;

    // Use this for initialization
    void Start () {
        logger.Log("creating " + this.gameObject.name);

        StartCoroutine(DestroyME());
    }

    // Update is called once per frame
    void Update () {
		
	}
    public IEnumerator DestroyME() {
        logger.Log("desroid " + this.gameObject.name);

        yield return new WaitForSeconds(detroyIn);
        Instantiate(dieEffectsPrefab, this.gameObject.transform.position + new Vector3(0, 1, 0), transform.rotation);

        Destroy(gameObject);
    }

}
