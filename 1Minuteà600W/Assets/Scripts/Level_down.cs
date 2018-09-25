using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_down : MonoBehaviour {
    public GameObject Hamster;
    public GameController GameCtrl;
    public Button Self;

    public void Start()
    {
        Self.onClick.AddListener(DoSmth);
    }

    public void DoSmth()
    {
        if ((Hamster.transform.position.x < -0.04f && Hamster.transform.position.x > -1.68f) && (GameCtrl._accessDown == false))
        {
            Hamster.GetComponent<PlayerController>()._yPos = -2.29f;
            Hamster.GetComponent<PlayerController>()._xPosMin = -2.7f;
            Hamster.GetComponent<PlayerController>()._xPosMax = 3.5f;
            GameCtrl._accessDown = true;
        }
        else if ((Hamster.transform.position.x < -0.04f && Hamster.transform.position.x > -1.68f) && (GameCtrl._accessDown == true))
        {
            Hamster.GetComponent<PlayerController>()._yPos = -0.09f;
            Hamster.GetComponent<PlayerController>()._xPosMin = -15f;
            Hamster.GetComponent<PlayerController>()._xPosMax = 15f;
            GameCtrl._accessDown = false;
        }
    }
}
