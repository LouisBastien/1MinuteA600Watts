using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Ventil : MonoBehaviour
{
    public GameController GameCtrl;
    public Button Self;
    public Sprite NextSprite;
    private bool Done = false;
    public Button Arrow;
    public Sprite ArrowSprite;

    void Start()
    {
        Self.onClick.AddListener(LockVentil);
    }

    public void LockVentil()
    {
        if (GameCtrl._vis == true && Done == false)
        {
            Arrow.image.overrideSprite = ArrowSprite;
            Done = true;
            GameCtrl._itemVis = false;
            GameCtrl._accessDown = true;
            Self.image.overrideSprite = NextSprite;
            Self.transform.position = new Vector3(Self.transform.position.x, Self.transform.position.y - 0.2f, Self.transform.position.z);
        }
        else if (GameCtrl._utiliser == true)
            Debug.Log("DEATH BY VENTILO -> ANIM DECOUPER PAR VENTILO");
    }
}