using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject door;
    bool isOpened=false;
    void OnTriggerEnter(Collider col)
    {
        if (!isOpened)
        {
            door.transform.position += new Vector3(0, 500, 0);
            isOpened = true;
            BGSoundScript.instance.gameObject.GetComponent<AudioSource>().Pause();
        }
    }

}
