using UnityEngine;
using UnityEngine.SceneManagement;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCamera;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "Teleport")
            {
                transform.position = new Vector3(0, 554, 0);
            }
        }

    }
}