using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Vis : MonoBehaviour
{
    public GameController GameCtrl;
    public GameObject Self;
    public Animator anim;

    // Use this for initialization
    void Start()
    {

    }

    public void takeVis()
    {
        if (GameCtrl._utiliser == true)
        {
            GameCtrl._itemVis = true;
            anim.SetTrigger("_IsRamasse");
            Destroy(Self);
        }
    }
}
