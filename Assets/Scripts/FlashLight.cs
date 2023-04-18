using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{

    GameObject flashLight;
    //bool click

    // Start is called before the first frame update
    void Start()
    {
        flashLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            flashLight.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            flashLight.SetActive(true);
        }

    }
}
