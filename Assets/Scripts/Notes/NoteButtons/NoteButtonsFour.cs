using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteButtonsFour : MonoBehaviour
{
    public NoteFour noteFour;
    public MouseLook mouseLook;


    public GameObject noteUIFourObject;
    public bool isCollectedNoteFour;


    public void Start()
    {
        noteUIFourObject.SetActive(false);
        isCollectedNoteFour = false;
    }

    public void NoteButtonFunction()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        noteUIFourObject.SetActive(false);
        isCollectedNoteFour = true;
        noteFour.noteFourObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseLook.isMousePaused = false;
    }

}
