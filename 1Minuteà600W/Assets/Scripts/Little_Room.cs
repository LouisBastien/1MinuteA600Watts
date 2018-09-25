using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Little_Room : MonoBehaviour {
    public GameObject hamster;
    public GameController GameCtrl;
    public GameObject Self;
    public Animator anim;

    public void GoInside()
    {
        if (GameCtrl._utiliser == true)
        {
            hamster.GetComponent<PlayerController>()._xPosMax = 15f;
            anim.SetTrigger("_IsRamasse");
            GameCtrl._itemGrille = true;
            GameCtrl._accesRight = true;
            Destroy(Self);
        }
    }
}
