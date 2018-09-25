using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_time : MonoBehaviour {
    public GameController GameCtrl;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

	// Update is called once per frame
	void Update () {
        if (GameCtrl.time <= 0)
            text.text = "0";
        else
            text.text = GameCtrl.time.ToString();
	}
}
