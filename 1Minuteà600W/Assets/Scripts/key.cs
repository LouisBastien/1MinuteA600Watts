using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {

    public GameController GameCtrl;
    public GameObject Self;
    public Animator anim;

    // Use this for initialization
    void Start()
    {

    }

    public void takeKey()
    {
        if (GameCtrl._utiliser == true)
        {
            GameCtrl._itemKey = true;
            anim.SetTrigger("_IsRamasse");
            Destroy(Self);
        }
    }
}
