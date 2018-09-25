using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wireBottom : MonoBehaviour {
    public Button Self;
    public GameController GameCtrl;
    public int wire;

    void Start()
    {
        GameCtrl.wirePositions[wire] = Self.transform.position;
        //print(wire + "is now in " + Self.transform.position);
        Self.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        print("clicked bottom");
    }
}
