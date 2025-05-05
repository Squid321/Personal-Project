using UnityEngine;
using System.Collections.Generic;
public class Checkpoints : MonoBehaviour
{
    public GameObject checkpoint;

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //List<GameObject> die = (GameObject.FindGameObjectsWithTag("Respawn"));
    }
    void OnTriggerEnter(Collider other) {
    GameObject[] AllObjects = GameObject.FindGameObjectsWithTag("Respawn");
    foreach(GameObject obj in AllObjects) {
            Destroy(obj);
    }
        Instantiate(checkpoint, transform.position,
            checkpoint.transform.rotation);
    }
}

