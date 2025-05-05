using UnityEngine;

public class Respawn : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            GameObject[] AllObjects = GameObject.FindGameObjectsWithTag("Respawn");
            foreach(GameObject obj in AllObjects) {
                
            }
            player.transform.position = (Vector3.up + transform.position);
            Debug.Log("It works!");
        }
    }
}
