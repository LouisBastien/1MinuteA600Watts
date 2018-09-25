using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Resistance : MonoBehaviour
{
    public bool Broken;
    public Button Self;
    public Sprite NextSprite;
    public GameController GameCtrl;
    public int ResistanceNumber;

    void Start()
    {
        Self.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (GameCtrl._mordre == true && GameCtrl._accessDown == true)
        {
            Self.image.overrideSprite = NextSprite;
            Broken = true;
            switch (ResistanceNumber)
            {
                case 1:
                    GameCtrl._firstResistance = true;
                    break;
                case 2:
                    GameCtrl._secondResistance = true;
                    break;
                case 3:
                    GameCtrl._goodResistance1 = true;
                    break;
                case 4:
                    GameCtrl._goodResistance2 = true;
                    break;
            }
        }
    }
}
