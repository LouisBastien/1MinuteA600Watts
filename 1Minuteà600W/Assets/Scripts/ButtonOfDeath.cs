using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonOfDeath : MonoBehaviour {

    public GameObject hamster;
    public GameController GameCtrl;
    public Animator anim;
    public Sprite pic;
    public Button currentButton;
    public Image img;
    public AudioSource clip;

    public void Update()
    {
    }

    public void ButtonUsed()
    {
        img = GetComponent<Image>();
       
        if (GameCtrl._utiliser == true && GameCtrl._accesRight == true)
        {
            Debug.Log("Button of Death");
            currentButton.interactable = true;
            img.sprite = pic;
            clip.Play();
            anim.SetBool("_DeathButton", true);
           StartCoroutine(Wait2sec());
        }
    }

    IEnumerator Wait2sec()
    {
        yield return new WaitForSeconds(0.2f);
        anim.SetBool("_DeathButton", false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("NaturalDeath");
    }
}
