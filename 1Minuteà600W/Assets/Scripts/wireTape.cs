using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wireTape : MonoBehaviour
{
    public GameObject gameController;
    public GameObject _this;
    private Vector3 newPosition;
    public Button Self;
    public int wire;

    // Use this for initialization
    void Start()
    {
        Self.onClick.AddListener(TaskOnClick);
        newPosition = Self.transform.position;
    }

    void TaskOnClick()
    {
        if (gameController.GetComponent<GameController>()._mordre == true)
        {
            Kys();
        }
    }

    void Kys()
    {
        Destroy(_this);
    }

    // Update is called once per frame
    void Update()
    {
        if (newPosition.z > -2)
        {
            newPosition.z -= 1;
            Self.transform.position = newPosition;
        }
    }
}
