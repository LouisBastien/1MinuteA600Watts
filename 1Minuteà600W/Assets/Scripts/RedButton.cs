using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RedButton : MonoBehaviour
{
    public GameController GameCtrl;
    public Button Self;
    public Sprite NextSprite;
    private bool _isRed = true;

    void Start()
    {
    }

    public void TriggerButton()
    {
        if (_isRed == true)
        {
            _isRed = false;
            GameCtrl._ButtonIsGreen = true;
            Self.image.overrideSprite = NextSprite;
        }
    }
}
