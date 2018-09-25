using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wireTop : MonoBehaviour {
    public Button Self;
    public GameObject GameCtrl;
    public GameObject _this;
    public GameObject tape;
    private Vector3 newPosition;
    public int wire;
    private int linked;
    private bool selected = false;


    void Start()
    {
        linked = wire;
        newPosition = Self.transform.position;
        Self.transform.position = newPosition;
        Self.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (selected)
        {
            selected = !selected;
            GameCtrl.GetComponent<GameController>()._utiliser = false;

            int i = 0;
            while (i < 3)
            {
                if (Mathf.Abs(GameCtrl.GetComponent<GameController>().wirePositions[i].x - Self.transform.position.x) < 0.25f)
                {
                    newPosition.x = GameCtrl.GetComponent<GameController>().wirePositions[i].x;
                    linked = i;
                    print(wire + " is now linked with " + i);
                    GameCtrl.GetComponent<GameController>().wireLink[i] = wire;
                    Self.transform.position = newPosition;
                    Instantiate(tape, Self.transform.position, Self.transform.rotation).transform.GetChild(0).transform.position = newPosition;
                    break;
                }
                i++;
            }
            //check if near any 
        }

        if ((!selected && GameCtrl.GetComponent<GameController>()._utiliser == true))
        {
            if (linked >= 0) {
                //print(wire + ": je me déconnecte " + linked);
                GameCtrl.GetComponent<GameController>().wireLink[linked] = -1;
                linked = -1;
            }
            selected = !selected;
        } 
    }

    private void Update()
    {
        if (newPosition.z > -1)
            newPosition.z -= 1;
        if (selected) {
            newPosition.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            if (newPosition.x > 12f && newPosition.x < 15f)
                Self.transform.position = newPosition;
        }
    }
}
