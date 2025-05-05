using UnityEngine;

public class Light : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject player;
    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(-2,3,-2);
    }
}
