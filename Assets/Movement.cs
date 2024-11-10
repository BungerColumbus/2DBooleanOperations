using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 movement;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += movement.normalized * speed * Time.deltaTime;
    }
}
