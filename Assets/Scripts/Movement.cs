using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float h;
    public float v;
    public float candash = 1;
    private float speed = 4;
    public float xx = 0;
    public float yy = 0;
    public float zz = 0;
    //private float dash = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetKey(KeyCode.Q))
        {
            GameObject[] AllObjects = GameObject.FindGameObjectsWithTag("Respawn");
            foreach(GameObject obj in AllObjects) {
                xx = obj.transform.position.x;
                yy = obj.transform.position.y;
                zz = obj.transform.position.z;
            }
            transform.position = (new Vector3(xx, yy+1, zz));
        }
    
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (candash == 0){
        if (verticalInput > 0){v=1;}
        if (verticalInput < 0){v=-1;}
        if (verticalInput == 0){v=0;}
        if (horizontalInput > 0){h=1;}
        if (horizontalInput < 0){h=-1;}
        if (horizontalInput == 0){h=0;}
        transform.position += (
        (Vector3.right * Time.deltaTime * v * speed)+
        (Vector3.forward * Time.deltaTime * v * speed)+
        (Vector3.right * Time.deltaTime * h * speed)+
        (-Vector3.forward * Time.deltaTime * h * speed));
        } 
        if (candash == 1){
        transform.position += (
        (Vector3.right * Time.deltaTime * verticalInput * speed)+
        (Vector3.forward * Time.deltaTime * verticalInput * speed)+
        (Vector3.right * Time.deltaTime * horizontalInput * speed)+
        (-Vector3.forward * Time.deltaTime * horizontalInput * speed));
        }
        {
        if (speed > 4){speed -= .25f;}
        if (speed < 4){speed = 4;}
        if (speed < 4.01f){candash = 1;}
        if (Input.GetKey(KeyCode.Space))
        {
            if (candash == 1)
            {
                speed = 15;
                candash = 0;
            }
        }
        }
        
    }
    
    
    
}
