using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public float horizontalInput;
    void Update()
    {
        horizontalInput =  Input.GetAxis(Horizontal);
    }
}
