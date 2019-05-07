using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour
{

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        if (!alreadyPlayed)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
        }
        StartCoroutine(Example());

    }
    public GameObject can;
    public GameObject move;
    IEnumerator Example()
    {
        yield return new WaitForSeconds(5f);
        can.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
}