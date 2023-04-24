using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTriggerOne : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public GameObject monster;
    public int count;


    // Start is called before the first frame update
    void Start()
    {
        monster.SetActive(false);
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player" && count == 0)
        {
            monster.SetActive(true);
            animator.SetBool("ClownOne", true);
            Debug.Log("Animation was played");
            count = 1;
        }

        if (player.gameObject.tag == "Player" && count == 1)
        {
            monster.SetActive(true);
            animator.SetBool("MonsterTriggerTwo", true);
            Debug.Log("Animation was played");
            count = 2;
        }
        if (player.gameObject.tag == "Player" && count == 2)
        {
            monster.SetActive(true);
            animator.SetBool("MonsterTriggerThree", true);
            Debug.Log("Animation was played");
            count = 3;
        }
    }
}
