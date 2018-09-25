using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_level : MonoBehaviour {
    public GameObject hamster;

    public void GoUp()
    {
        Debug.Log("Go Up");
        if (hamster.transform.position.x < -0.04f && hamster.transform.position.x > -1.68f && hamster.transform.position.y == -2.35f)
        {
            hamster.GetComponent<PlayerController>()._yPos = -0.15f;
            hamster.GetComponent<PlayerController>()._xPosMin = -15f;
            hamster.GetComponent<PlayerController>()._xPosMax = 15f;
        }
    }
}
