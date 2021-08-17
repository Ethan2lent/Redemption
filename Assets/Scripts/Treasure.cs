using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Treasure : MonoBehaviour
{
    public static int treasure;

    private void Start()
    {
        treasure = 0;
    }

    void Update()
    {
        //Will display the score
        gameObject.GetComponent<Text>().text = treasure.ToString();
    }

    public void treasureCt()
    {
        treasure += 1;
    }
}
