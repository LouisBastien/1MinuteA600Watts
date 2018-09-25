using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {
    public int time;
    public GameObject PlayerController;

	// Use this for initialization
	void Start () {
        InvokeRepeating("UpdateTime", 0, 1);
	}
	
    void UpdateTime() {
        time--;

            if (time == 40)
                SendMessage("setState", 1);
            if (time == 20)
                SendMessage("setState", 2);
    }

}
