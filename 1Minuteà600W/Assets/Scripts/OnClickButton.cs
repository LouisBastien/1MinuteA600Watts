using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickButton : MonoBehaviour
{
    public Button Self;

    void Start()
    {
        Self.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
