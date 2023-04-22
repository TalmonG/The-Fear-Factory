using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteThree : MonoBehaviour
{
    public NoteButtonsThree noteButtonsThree;
    public MouseLook mouseLook;
    public Accessibility accessibility;

    public GameObject noteThreeObject;
    public GameObject noteUIThreeObject;

    public GameObject e;
    public bool ableCollectNoteThree;

    void Awake()
    {
        noteUIThreeObject.SetActive(false);
    }

    void Start()
    {
        e.SetActive(false);
        noteUIThreeObject.SetActive(false);
        ableCollectNoteThree = true;


    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            e.SetActive(true);
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKeyDown(KeyCode.E) && ableCollectNoteThree == true)
        {
            noteUIThreeObject.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Click");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            mouseLook.isMousePaused = true;
            ableCollectNoteThree = false;

            if (accessibility.IsNarratorEnabled == true)
            {
                FindObjectOfType<AudioManager>().Play("Note 3");
            }

        }

        if (noteButtonsThree.isCollectedNoteThree == true && ableCollectNoteThree == true)
        {
            noteThreeObject.SetActive(false);
            ableCollectNoteThree = false;
        }
    }

    void OnTriggerExit(Collider player)
    {
        e.SetActive(false);

    }
}
