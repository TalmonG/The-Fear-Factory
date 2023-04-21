using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteButtonsOne : MonoBehaviour
{
    public NoteOne noteOne;
    public MouseLook mouseLook;


    public GameObject noteUIOneObject;
    public bool isCollectedNoteOne;


    public void Start()
    {
        noteUIOneObject.SetActive(false);
        isCollectedNoteOne = false;
    }

    public void NoteButtonFunction()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        noteUIOneObject.SetActive(false);
        isCollectedNoteOne = true;
        noteOne.noteOneObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseLook.isMousePaused = false;
    }

}
