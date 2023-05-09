using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{

    [SerializeField] private Animator animator;

    public bool isFinalDoorOpen;
    // Start is called before the first frame update
    void Awake()
    {
        isFinalDoorOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFinalDoorOpen == true)
        {
            animator.SetBool("FinalDoorAnim", true);
        }
    }



}
