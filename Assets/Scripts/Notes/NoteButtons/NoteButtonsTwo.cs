using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteButtonsTwo : MonoBehaviour
{
    public NoteTwo noteTwo;
    public MouseLook mouseLook;


    public GameObject noteUITwoObject;
    public bool isCollectedNoteTwo;


    public void Start()
    {
        noteUITwoObject.SetActive(false);
        isCollectedNoteTwo = false;
    }

    public void NoteButtonFunction()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        noteUITwoObject.SetActive(false);
        isCollectedNoteTwo = true;
        noteTwo.noteTwoObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseLook.isMousePaused = false;
    }

}
