using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureDoor : MonoBehaviour
{
    public AudioSource audioSource;
    public int treasureCounter;
    void Start()
    {
        treasureCounter = 0;
    }

    // Update is called once per frames
    void Update()
    {
        if (treasureCounter == 4)
        {
            audioSource.Play();
            Destroy(gameObject);
        }
    }

    public void treasureCount()
    {
        treasureCounter += 1;
    }
}
