﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAudio : MonoBehaviour {

    public AudioSource audioNamiFeliz,audioNamiTriste,audioClic;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playNamiFeliz()
    {
        audioNamiFeliz.Play();
    }

    public void playNamiTriste()
    {
        audioNamiTriste.Play();
    }

    public void playClic()
    {
        audioClic.Play();
    }
}
