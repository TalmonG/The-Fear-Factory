using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteButtonsThree : MonoBehaviour
{
    public NoteThree noteThree;
    public MouseLook mouseLook;


    public GameObject noteUIThreeObject;
    public bool isCollectedNoteThree;


    public void Start()
    {
        noteUIThreeObject.SetActive(false);
        isCollectedNoteThree = false;
    }

    public void NoteButtonFunction()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        noteUIThreeObject.SetActive(false);
        isCollectedNoteThree = true;
        noteThree.noteThreeObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseLook.isMousePaused = false;
    }

}
