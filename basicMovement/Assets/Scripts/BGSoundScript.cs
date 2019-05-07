using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BGSoundScript : MonoBehaviour { // Start is called before the first frame update 
    void Start()
    {

    }

    public static BGSoundScript instance = null;
    void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject); return;
        }
        else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}﻿