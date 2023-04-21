using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteButtonsFive : MonoBehaviour
{
    public NoteFive noteFive;
    public MouseLook mouseLook;


    public GameObject noteUIFiveObject;
    public bool isCollectedNoteFive;


    public void Start()
    {
        noteUIFiveObject.SetActive(false);
        isCollectedNoteFive = false;
    }

    public void NoteButtonFunction()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        noteUIFiveObject.SetActive(false);
        isCollectedNoteFive = true;
        noteFive.noteFiveObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseLook.isMousePaused = false;
    }

}
