using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wire : MonoBehaviour {
    public GameObject gameController;
    public GameObject _this;
    public GameObject top;
    public GameObject bottom;
    public Button button;
    public int id;
	// Use this for initialization
	void Start () {
        button.onClick.AddListener(TaskOnClick);
	}

    void TaskOnClick() {
        //print("clicked this " + _this.transform.position.x + " " + _this.transform.position.y);
        //print("I have: " + Instantiate(top, _this.transform.position, _this.transform.rotation).transform.position);
        if (gameController.GetComponent<GameController>()._mordre == true) { 
            Instantiate(top, _this.transform.position, _this.transform.rotation).transform.GetChild(0).transform.position = button.transform.position;
            gameController.GetComponent<GameController>().wirePositions[id] = button.transform.position;
            Instantiate(bottom, _this.transform.position, _this.transform.rotation).transform.GetChild(0).transform.position = button.transform.position;
            Kys();
        }
    }

    void Kys() {
        _this.gameObject.SetActive(false);
    }
   
    // Update is called once per frame
    void Update () {
		
	}
}
