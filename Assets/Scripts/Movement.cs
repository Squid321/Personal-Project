using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.position += (
        (Vector3.right * Time.deltaTime * verticalInput * 4)+
        (Vector3.forward * Time.deltaTime * verticalInput * 4)+
        (Vector3.right * Time.deltaTime * horizontalInput * 4)+
        (-Vector3.forward * Time.deltaTime * horizontalInput * 4));
    }
}
