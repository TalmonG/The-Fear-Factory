using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterChase : MonoBehaviour
{

    public GameObject monster;
    //[SerializeField] private Animator animator;

    // Start is called before the first frame update
    void Awake()
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
            

        }
    }

}
