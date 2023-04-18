using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsUnlock : MonoBehaviour
{
    public GameObject RedDoor;
    public CardSwipers CardSwipers;
    [SerializeField] private Animator animator;
    public GameObject DoorOpens;
    public bool DoorOpenStatus = false;

    public GameObject RedDoorUnlockText;

    // Start is called before the first frame update
    void Awake()
    {
        RedDoorUnlockText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (CardSwipers.redCardSwiperUnlockStatus == true && DoorOpenStatus == false)
        {
            FindObjectOfType<AudioManager>().Play("DoorOpening");
            animator.SetBool("RedDoorOpen", true);
            FindObjectOfType<AudioManager>().Play("Suspense");
            DoorOpenStatus = true;
            FindObjectOfType<AudioManager>().Play("Nice");
            StartCoroutine(RedDoorUnlockTextTimer());


        }
    }

    IEnumerator RedDoorUnlockTextTimer()
    {
        RedDoorUnlockText.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        RedDoorUnlockText.SetActive(false);
    }

}
