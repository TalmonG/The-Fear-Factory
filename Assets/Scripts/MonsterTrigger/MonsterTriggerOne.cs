using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTriggerOne : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public GameObject monster;


    // Start is called before the first frame update
    void Start()
    {
        monster.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            monster.SetActive(true);
            animator.SetBool("MonsterTriggerOne", true);
            Debug.Log("Animation was played");
        }
    }
}
