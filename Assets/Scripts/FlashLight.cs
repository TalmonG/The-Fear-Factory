using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{

    public GameObject flashLight;
    public bool click;

    // Start is called before the first frame update
    void Start()
    {
        flashLight.SetActive(false);
        bool click = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            flashLight.SetActive(true);
        }
        /*else
        {
            flashLight.SetActive(false);
        }*/

        if (Input.GetMouseButtonUp(0))
        {
            flashLight.SetActive(false);
        }

    }
}
