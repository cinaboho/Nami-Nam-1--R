﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class Controladorvideo : MonoBehaviour {

    public AudioSource audioClic;
    public VideoPlayer video;
    public GameObject bttPlay;
    public GameObject bttStop;
    // Use this for initialization
    void Start () {
        StartCoroutine(cargarEscena());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IrMenu()
    {
        audioClic.Play();
        StartCoroutine(Transicion("Menuinicio"));

    }

    public void Playvideo()
    {
        audioClic.Play();
        video.Play();
        bttPlay.SetActive(false);
        bttStop.SetActive(true);
    }

    public void StopVideo()
    {
        audioClic.Play();
        video.Pause();
        bttStop.SetActive(false);
        bttPlay.SetActive(true);
    }

    public void NextScene(string scene)
    {
        StartCoroutine(Transicion(scene));
    }

    public void RestartVideo()
    {
        audioClic.Play();
        video.Stop();
        video.Play();
        StartCoroutine(cargarEscena());
    }

    IEnumerator Transicion(string scene)
    {
        yield return new WaitForSeconds(0.1f);
            SceneManager.LoadScene(scene);

    }

    IEnumerator cargarEscena()
    {
        video.Prepare();
        GameObject.Find("btnmenu").GetComponent<Button>().enabled = false;
        GameObject.Find("btnmenu").GetComponent<Image>().enabled = false;

        GameObject.Find("btnrepetir").GetComponent<Button>().enabled = false;
        GameObject.Find("btnrepetir").GetComponent<Image>().enabled = false;

        yield return new WaitForSecondsRealtime(28f);
        GameObject.Find("btnmenu").GetComponent<Button>().enabled = true;
        GameObject.Find("btnmenu").GetComponent<Image>().enabled = true;

        GameObject.Find("btnrepetir").GetComponent<Button>().enabled = true;
        GameObject.Find("btnrepetir").GetComponent<Image>().enabled = true;

        /* yield return new WaitForSecondsRealtime(video.frameRate);
         yield return new WaitForSecondsRealtime(1f);
         SceneManager.LoadScene("Menuinicio");*/
    }



}
