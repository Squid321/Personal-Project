using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(player, transform.position,
            player.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
