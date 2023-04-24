using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GettingCaughtVideoScript : MonoBehaviour
{
    public GameObject VideoScreen;

    public VideoPlayer myVideoPlayer;

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
            
            VideoScreen.SetActive(true);
            myVideoPlayer.Play();
            Debug.Log("STUPEDDDD");
            count = 0;

        }
    }
}