using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject can;
    public GameObject move;
    void Start()
    {

        StartCoroutine(Example());
   }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(5f);
        can.SetActive(true);
        move.GetComponent<charControl>().enabled = false;
        move.GetComponent<charMove>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
}
