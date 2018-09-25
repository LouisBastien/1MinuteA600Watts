using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Floor : MonoBehaviour
{
    public Animator anim;
    public GameObject GameController;
    public GameObject Self;
    public Sprite _next_sprite;
    private Button yourButton;


    // Use this for initialization
    void Start()
    {
        yourButton = Self.GetComponent<Button>();
        yourButton.onClick.AddListener(UpFloor);
    }

    public void UpFloor()
    {
        if (GameController.GetComponent<GameController>()._grille == true)
        {
            GameController.GetComponent<GameController>()._itemGrille = false;
            yourButton.image.overrideSprite = _next_sprite;
            anim.SetTrigger("_IsRamasse");
            Self.transform.position = new Vector3(Self.transform.position.x, Self.transform.position.y + 2.25f, Self.transform.position.z);
            Self.transform.localScale = new Vector3(Self.transform.localScale.x, Self.transform.localScale.y + 0.75f, Self.transform.localScale.z);
        }
    }

}