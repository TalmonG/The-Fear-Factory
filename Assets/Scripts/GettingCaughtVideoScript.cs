using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class GettingCaughtVideoScript : MonoBehaviour
{
    public GameObject VideoScreen;

    public VideoPlayer myVideoPlayer;

    public MouseLook mouseLook;

    public bool isPlaying;
    public int timeToStop;


    public int count;
    

    public bool isplayercaught;
    
    void Start()
    {
        count = 1;
        VideoScreen.SetActive(false);
        //VideoScreen.SetActive(true);
        VideoScreen.SetActive(false);
        //myVideoPlayer.loopPointReached += DoSomethingWhenVideoFinish;
        isplayercaught = false;
    }

    void DoSomethingWhenVideoFinish(VideoPlayer vp)
    {
        VideoScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isplayercaught == true && count == 1)
        {
            FindObjectOfType<AudioManager>().Play("CaughtSound");
            VideoScreen.SetActive(true);
            myVideoPlayer.Play();
            Debug.Log("STUPEDDDD");
            count = 0;
            StartCoroutine(CoFunc());

        }
    }

    IEnumerator CoFunc()
    {
        yield return new WaitForSeconds(timeToStop);
        Debug.Log("a");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        mouseLook.isMousePaused = true;
        SceneManager.LoadScene(0);
    }
}