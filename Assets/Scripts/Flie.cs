using UnityEngine;

public class Flie : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 40.0f;
    public float topBound = 30.0f;
    public float lowBound = -10.0f;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        }
        if (transform.position.z < lowBound) {
            Destroy(gameObject);
        }
    }
}
