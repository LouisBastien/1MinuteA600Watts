using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CleanGraisse : MonoBehaviour
{
    public int _hp;
    public GameController GameCtrl;
    public Button Self;
    public Animator anim;
    public Sprite OneSprite;
    public Sprite TwoSprite;
    public GameObject MainSelf;

    void Start()
    {
      //  anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (_hp == 2)
            Self.image.overrideSprite = OneSprite;
        if (_hp == 1)
            Self.image.overrideSprite = TwoSprite;
        if (_hp == 0)
            Destroy(MainSelf);
    }

    public void decreaseLife()
    {
        if (GameCtrl.GetComponent<GameController>()._lécher == true)
        {
            _hp--;
            anim.SetTrigger("_IsLicking");
        }
        else if (GameCtrl.GetComponent<GameController>()._gratter == true)
            Debug.Log("DEATH BY BLOOD -> ANIM DEATH OUT OF BLOOD");
    }
}
