using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject doorPivot;

    public void OpenDoor()
    {
        doorPivot.transform.Rotate(0f, 90f, 0f);
    }
}
