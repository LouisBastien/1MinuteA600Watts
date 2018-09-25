using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public int time;
    public bool _utiliser = false;
    public bool _lécher = false;
    public bool _mordre = false;
    public bool _gratter = false;
    public bool _vis = false;
    public bool _key = false;
    public bool _stamp = false;
    public bool _grille = false;
    public bool _ButtonIsGreen = false;

    public Button VisButton;
    public Button GrilleButton;
    public Button StampButton;
    public Button KeyButton;
    public Button RedButton;

    public bool _itemVis = false;
    public bool _itemGrille = false;
    public bool _itemKey = false;
    public bool _itemStamp = false;

    public bool _accessDown = false;
    public bool _accesRight = false;

    public bool _firstResistance = false;
    public bool _secondResistance = false;

    public bool _goodResistance1 = false;
    public bool _goodResistance2 = false;

    public Vector3[] wirePositions;
    public int[] wireLink;
    public Animator anim;
    public AudioSource clip;
    public AudioSource elec;

    void Start () {
        VisButton.gameObject.SetActive(false);
        GrilleButton.gameObject.SetActive(false);
        wirePositions = new Vector3[3];
        wireLink = new int[3];
        InvokeRepeating("UpdateTime", 0, 1);
    }

    void Update()
    {
        //print("link: 0:" + wireLink[0] + " 1:" + wireLink[1] + " 2:" + wireLink[2]);
        //print("pos: 0:" + wirePositions[0] + " 1:" + wirePositions[1] + " 2:" + wirePositions[2]);
        if (wireLink[0] == 1 && wireLink[1] == 2 && wireLink[2] == 0) {
            _ButtonIsGreen = true;
            RedButton.SendMessage("TriggerButton");
            //print("are you winnin son?");
        }
        if (_accessDown == true)
        {
            // Check des Resistances
            int i = 0;

            if (_firstResistance)
                i += 1;
            if (_secondResistance)
                i += 1;
            if (_goodResistance1)
                i += 1;
            if (_goodResistance2)
                i += 1;
            if (i == 2)
            {
                if (_goodResistance1 && _goodResistance2 && _ButtonIsGreen)
                    SceneManager.LoadScene("Win");
                else
                {
                    anim.SetBool("_DeathElec", true);
                    elec.Play();
                    StartCoroutine(Wait3sec());
                    // Dead
                }
            }
        }

        if (_itemVis == true)
            VisButton.gameObject.SetActive(true);
        else
            VisButton.gameObject.SetActive(false);
        if (_itemGrille == true)
            GrilleButton.gameObject.SetActive(true);
        else
            GrilleButton.gameObject.SetActive(false);


        if (_itemKey == true)
            KeyButton.gameObject.SetActive(true);
        else
            KeyButton.gameObject.SetActive(false);
        if (_itemStamp == true)
            StampButton.gameObject.SetActive(true);
        else
            StampButton.gameObject.SetActive(false);
        if (time == 0)
        {
            clip.Play();
            StartCoroutine(Wait1sec());
            clip.Play();
            StartCoroutine(ChargeGO());
        }

    }

    IEnumerator Wait1sec()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("_IsDead", true);
    }

    IEnumerator Wait3sec()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NaturalDeath");
    }


    IEnumerator ChargeGO()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameOver");
    }

    void UpdateTime()
    {
        time--;
    }

    public void setUseTrue()
    {
        _gratter = false;
        _mordre = false;
        _lécher = false;
        _utiliser = true;
        _vis = false;
        _grille = false;
    }

    public void setLickTrue()
    {
        _gratter = false;
        _mordre = false;
        _lécher = true;
        _utiliser = false;
        _vis = false;
        _grille = false;
    }

    public void setBiteTrue()
    {
        _gratter = false;
        _mordre = true;
        _lécher = false;
        _utiliser = false;
        _vis = false;
        _grille = false;
    }

    public void setGratterTrue()
    {
        _gratter = true;
        _mordre = false;
        _lécher = false;
        _utiliser = false;
        _vis = false;
        _grille = false;
    }

    public void setVisTrue()
    {
        _gratter = false;
        _mordre = false;
        _lécher = false;
        _utiliser = false;
        _vis = true;
        _grille = false;
    }

    public void setGrilleTrue()
    {
        _gratter = false;
        _mordre = false;
        _lécher = false;
        _utiliser = false;
        _vis = false;
        _grille = true;
    }
}
