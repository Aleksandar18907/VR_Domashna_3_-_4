using UnityEngine;

public class charControl : MonoBehaviour
{
    public int speed;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;

        }
        
    }
}
