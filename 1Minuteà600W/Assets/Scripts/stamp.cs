using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stamp : MonoBehaviour {
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
            GameCtrl._itemStamp = true;
            anim.SetTrigger("_IsRamasse");
            Destroy(Self);
        }
    }
}
