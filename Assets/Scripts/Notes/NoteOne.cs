using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteOne : MonoBehaviour
{
    public NoteButtonsOne noteButtonsOne;
    public MouseLook mouseLook;
    public Accessibility accessibility;

    public GameObject noteOneObject;
    public GameObject noteUIOneObject;
    public bool isNoteCollected;

    public GameObject e;
    public bool ableCollectNoteOne;

    void Awake()
    {
        noteUIOneObject.SetActive(false);
        isNoteCollected = false;
    }

    void Start()
    {
        e.SetActive(false);
        noteUIOneObject.SetActive(false);
        ableCollectNoteOne = true;


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
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.U))
        {
            if (ableCollectNoteOne == true)
            {
                noteUIOneObject.SetActive(true);
                FindObjectOfType<AudioManager>().Play("Click");
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                mouseLook.isMousePaused = true;
                ableCollectNoteOne = false;

                if (accessibility.IsNarratorEnabled == true)
                {
                    FindObjectOfType<AudioManager>().Play("Mr. Winters");
                }

                isNoteCollected = true;
            }
        }
        if (noteButtonsOne.isCollectedNoteOne == true && ableCollectNoteOne == true)
        {
            noteOneObject.SetActive(false);
            ableCollectNoteOne = false;
        }
    }

    void OnTriggerExit(Collider player)
    {
        e.SetActive(false);

    }
}
