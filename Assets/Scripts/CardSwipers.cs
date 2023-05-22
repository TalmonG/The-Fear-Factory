using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSwipers : MonoBehaviour
{
    public KeyCards KeyCards;
    public Dialogue dialogue;
    public Accessibility accessibility;
    //public GameObject redKeyCardTextGameObject;



    [Header("Card Swipers")]
    public GameObject redCardSwiper_StatusDenied;
    public GameObject redCardSwiper_StatusGranted;

    [Header("Card Swipers Unlocked")]
    public bool redCardSwiperUnlockStatus = false;
    public bool redKeyCardCollected = false;

    public bool redCardSwiperUsable;

    public GameObject redCardSwiperE;

    public GameObject redKeyCardText;

    private void Awake()
    {
        redCardSwiperUsable = false;
        redCardSwiper_StatusDenied.SetActive(true);
        redCardSwiper_StatusGranted.SetActive(false);
        redCardSwiperE.SetActive(false);
        redKeyCardText.SetActive(false);



    }



    void OnTriggerStay(Collider player)
    {
        if (player.gameObject.tag == "Player" && redCardSwiperUnlockStatus == true)
        {
            redCardSwiperE.SetActive(false);
        }
            if (Input.GetKeyDown(KeyCode.E) || (Input.GetKeyDown(KeyCode.U)))
        {
            if (KeyCards.redKeyCard == true && redCardSwiperUnlockStatus == false)
            {
                FindObjectOfType<AudioManager>().Play("Click");
                redCardSwiper_StatusDenied.SetActive(false);
                redCardSwiper_StatusGranted.SetActive(true);
                redCardSwiperE.SetActive(true);
                redCardSwiperUnlockStatus = true;
                Debug.Log("DDDDDDD");

            }


        }
        if ((Input.GetKeyDown(KeyCode.E) || (Input.GetKeyDown(KeyCode.U))))
        {
            if (KeyCards.redKeyCard == false)
            {
                if (accessibility.IsNarratorEnabled == true)
                {
                    FindObjectOfType<AudioManager>().Play("Red Key Card");
                }

                if (accessibility.IsSubtitlesEnabled == true)
                {
                    redKeyCardText.SetActive(true);
                    StartCoroutine(RedKeyCardTextTimer());
                }
            }

        }

        IEnumerator RedKeyCardTextTimer()
        {
            redKeyCardText.SetActive(true);
            yield return new WaitForSecondsRealtime(5);
            redKeyCardText.SetActive(false);
        }
    }
        

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player" && redCardSwiperUnlockStatus == false)
        {
            redCardSwiperE.SetActive(true);
            redCardSwiperUsable = true;

            if (player.gameObject.tag == "Player" && KeyCards.redKeyCard == false)
            {
            }
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player" && redCardSwiperUnlockStatus == true)
        {
            redCardSwiperE.SetActive(false);
            redCardSwiperUsable = false;
        }

        if (player.gameObject.tag == "Player" && redCardSwiperUnlockStatus == false)
        {
            redCardSwiperE.SetActive(false);
            redCardSwiperUsable = false;
        }
    }

}
