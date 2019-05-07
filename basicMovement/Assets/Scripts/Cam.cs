using UnityEngine;

public class Cam : MonoBehaviour
{
    Vector2 mouseLook;
    public float sensitivity;
    GameObject character;

    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        float vertical = Input.GetAxis("Mouse Y");

        Vector2 look = new Vector2(horizontal, vertical);
        mouseLook += look * sensitivity;

        mouseLook.y = Mathf.Clamp(mouseLook.y, -80f, 80);
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
       
    }
}