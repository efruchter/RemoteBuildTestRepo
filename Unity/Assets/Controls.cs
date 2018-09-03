using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Jenkins!");
    }

    void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
