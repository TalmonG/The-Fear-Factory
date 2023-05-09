using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTwo : MonoBehaviour
{
    public NoteButtonsTwo noteButtonsTwo;
    public MouseLook mouseLook;
    public Accessibility accessibility;

    public GameObject noteTwoObject;
    public GameObject noteUITwoObject;
    public bool isNoteCollected;

    public GameObject e;
    public bool ableCollectNoteTwo;

    void Awake()
    {
        noteUITwoObject.SetActive(false);
        isNoteCollected = false;
    }

    void Start()
    {
        e.SetActive(false);
        noteUITwoObject.SetActive(false);
        ableCollectNoteTwo = true;


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
        if (Input.GetKeyDown(KeyCode.E) && ableCollectNoteTwo == true)
        {
            noteUITwoObject.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Click");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            mouseLook.isMousePaused = true;
            ableCollectNoteTwo = false;

            if (accessibility.IsNarratorEnabled == true)
            {
                FindObjectOfType<AudioManager>().Play("Note 2");
            }
            isNoteCollected = true;

        }

        if (noteButtonsTwo.isCollectedNoteTwo == true && ableCollectNoteTwo == true)
        {
            noteTwoObject.SetActive(false);
            ableCollectNoteTwo = false;
        }
    }

    void OnTriggerExit(Collider player)
    {
        e.SetActive(false);

    }
}
