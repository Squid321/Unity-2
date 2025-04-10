using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 25.0f;
    public float horizontalInput;
    public GameObject projectile;
    void Update()
    {
    
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        if (transform.position.x < -18) {
            transform.position = new Vector3(-18, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 18) {
            transform.position = new Vector3(18, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }if (Input.GetKeyUp(KeyCode.Space)) {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }
}
