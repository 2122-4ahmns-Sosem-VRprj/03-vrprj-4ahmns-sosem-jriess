using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenManager : MonoBehaviour
{
    public GameObject chicken;
    public Transform chickenSpawnOne;
    public Transform chickenSpawnTwo;
    public Transform chickenSpawnThree;

    private void Start()
    {
        SpawnChickens();
    }

    void SpawnChickens()
    {
        Instantiate(chicken, chickenSpawnOne.position, Quaternion.identity);
        Instantiate(chicken, chickenSpawnTwo.position, Quaternion.identity);
        Instantiate(chicken, chickenSpawnThree.position, Quaternion.identity);
    }
}
