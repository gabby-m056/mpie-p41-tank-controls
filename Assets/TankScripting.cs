using UnityEngine;

public class TankScripting : MonoBehaviour
{
    public float speed = 50.0f
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float throttle = Input.GetAxis("Vertical");
        float movement = throttle * speed * Time.deltaTime;

        Transform t = gameObject.transform;
        t.Translate (0.0f, 0.0f, movement);
    }
}
