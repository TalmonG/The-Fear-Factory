using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteOne : MonoBehaviour
{
    public NoteButtonsOne noteButtonsOne;
    public MouseLook mouseLook;

    public GameObject noteOneObject;
    public GameObject noteUIOneObject;

    public GameObject e;
    public bool ableCollectNoteOne;

    void Awake()
    {
        noteUIOneObject.SetActive(false);
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
        if (Input.GetKeyDown(KeyCode.E) && ableCollectNoteOne == true)
        {
            noteUIOneObject.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Click");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            mouseLook.isMousePaused = true;
            ableCollectNoteOne = false;



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
