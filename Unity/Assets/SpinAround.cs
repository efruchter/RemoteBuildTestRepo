using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAround : MonoBehaviour
{
	void Update ()
    {
	    transform.rotation *= Quaternion.Euler(Time.deltaTime * 90f / 2, Time.deltaTime * 90f / 3, Time.deltaTime * 90f / 4f);
	}
}
