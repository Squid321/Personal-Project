using UnityEngine;
using System.Collections.Generic;
public class Switches : MonoBehaviour
{
    public GameObject checkpoint;
    public float xx;
    public float yy;
    public float zz;
    public float group;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<GameObject> die = new List<GameObject>(GameObject.FindGameObjectsWithTag("Respawn"));
    }

    // Update is called once per frame
    void Update()
    {
        //List<GameObject> die = (GameObject.FindGameObjectsWithTag("Respawn"));
    }
    void OnTriggerEnter(Collider other) {
        //Instantiate(checkpoint, new Vector3(xx, yy, zz), Vector3.zero);
        //new Vector3(Random.Range(-16, 16), 0, 20)
    //    foreach(GameObject die in die){
    //values = new Vector3 (1, 1, 1);
    //}
        //foreach(){
        //    Destroy(GameObject);
        //}
        Instantiate(checkpoint, transform.position,
            checkpoint.transform.rotation);
        Debug.Log("It Works!");
        //other.gameObject.CompareTag("ballz")
    }
}

