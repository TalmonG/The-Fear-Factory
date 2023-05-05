using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTask : MonoBehaviour
{
    [Header("Card Swipers Unlocked?")]
    public bool lightSwitchStatus = false;

    public GameObject lights;
    public GameObject monsterStatue;
    public GameObject dirtPath;
    public GameObject holeCover;

    public GameObject EPrompt;
    private void Awake()
    {
        EPrompt.SetActive(false);
        lightSwitchStatus = false;
        monsterStatue.SetActive(true);
        holeCover.SetActive(true);
        lights.SetActive(false);
        dirtPath.SetActive(false);
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKeyDown(KeyCode.E) && lightSwitchStatus == false)
        {
            FindObjectOfType<AudioManager>().Play("Click");
            FindObjectOfType<AudioManager>().Play("MonsterScreech");
            FindObjectOfType<AudioManager>().Play("Breaking");
            lightSwitchStatus = true;
            Debug.Log("It was Switched");
            EPrompt.SetActive(false);
            lights.SetActive(true);
            monsterStatue.SetActive(false);
            holeCover.SetActive(false);
            dirtPath.SetActive(true);
            Debug.Log("Lights are turned on now!");
        }
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player" && lightSwitchStatus == false)
        {
            EPrompt.SetActive(true);
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            EPrompt.SetActive(false);
        }
    }
}
