using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Animator anim;
    public float _xPosMin;
    public float _xPosMax;
    public float _yPos;
    public bool _orientation;
    public int state;

    private Vector3 target;

    void setState(int NewState)
    {
        state = NewState;
    }

    void Start () {
        setState(0);
        anim = GetComponent<Animator>();
        anim.SetBool("_FacingLeft", true);
        target = transform.position;
    }
	
	void Update () {
       if (state == 0)
            anim.SetInteger("_State", 0);
        else if (state == 1)
            anim.SetInteger("_State", 1);
        else if (state == 2)
            anim.SetInteger("_State", 2);

        anim.SetBool("_GoingLeft", false);
        anim.SetBool("_GoingRight", false);
        if (Input.GetMouseButtonDown(1))
        {
           target = Input.mousePosition;
           target = Camera.main.ScreenToWorldPoint(target);
        }
        if (target.x - transform.position.x < 1 && target.x - transform.position.x > -1)
        {
            anim.SetBool("_IsIdle", true);
            anim.SetBool("_GoingLeft", false);
            anim.SetBool("_GoingRight", false);
        }
        else if (target.x >= transform.position.x)
        {
            anim.SetBool("_GoingLeft", false);
            anim.SetBool("_IsIdle", false);
            anim.SetBool("_GoingRight", true);
            anim.SetBool("_FacingLeft", false);
            _orientation = false; // RIGHT;
        }
        else if (target.x <= transform.position.x)
        {
            anim.SetBool("_GoingRight", false);
            anim.SetBool("_IsIdle", false);
            anim.SetBool("_GoingLeft", true);
            anim.SetBool("_FacingLeft", true);
            _orientation = true; // LEFT;
        }
        target.z = transform.position.z;
        target.y = _yPos;
        Vector3 tmp = transform.position;
            tmp = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
        if (tmp.x >= _xPosMin && tmp.x <= _xPosMax)
        {
            transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
        }
        else
        {
            target = transform.position;
            anim.SetBool("_IsIdle", true);
        }
    }
}