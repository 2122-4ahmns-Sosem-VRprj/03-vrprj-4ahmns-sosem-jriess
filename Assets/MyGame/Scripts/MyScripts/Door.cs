using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject doorPivot;

    private void Start()
    {
        OpenDoor();
    }

    public void OpenDoor()
    {
        doorPivot.transform.Rotate(0f, 90f, 0f);
    }
}
