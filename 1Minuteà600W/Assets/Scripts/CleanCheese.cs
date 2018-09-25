using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CleanCheese : MonoBehaviour
{
    public int _hp;
    public GameController GameCtrl;
    public GameObject _item;
    public Button Self;
    public Button Vis;
    public Sprite OneSprite;
    public Sprite TwoSprite;
    private bool Done = false;

    public Animator anim;

    void Start()
    {
        Self.onClick.AddListener(decreaseLife);
        Vis.interactable = false;
    }

    void Update()
    {
        if (_hp == 2 && !Done)
        {
            Done = true;
            Self.image.overrideSprite = OneSprite;
            Self.transform.position = Self.transform.position + new Vector3(0.0f, -0.15f, 0.0f);
        }
        if (_hp == 1)
            Self.image.overrideSprite = TwoSprite;
        if (_hp == 0)
        {
            Vis.interactable = true;
            Destroy(_item);
        }
    }

    public void decreaseLife()
    {
        if (GameCtrl._gratter == true)
        {
            _hp--;
            anim.SetTrigger("_IsGratte");
        }
        else if (GameCtrl._lécher == true)
        {
            Debug.Log("DEATH BY VIS -> ANIM EMAPLLER VIS");
            anim.SetTrigger("_IsLicking");
        }
    }
}
