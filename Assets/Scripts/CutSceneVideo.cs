using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CutSceneVideo : MonoBehaviour
{

    CutSceneScript cutSceneScritp;
    public GameObject pauseMenu;

    public GameObject VideoScreen;

    public VideoPlayer myVideoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        VideoScreen.SetActive(true);
        myVideoPlayer.loopPointReached += DoSomethingWhenVideoFinish;
    }

    void DoSomethingWhenVideoFinish(VideoPlayer vp)
    {
        Debug.Log("Video is doneeee");
        VideoScreen.SetActive(false);
        pauseMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
