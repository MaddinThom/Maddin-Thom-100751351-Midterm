using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController cc;
    private float movespeed;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 1f;
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        //rot = rot.normalized;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        cc.Move(move * Time.deltaTime * movespeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
            anim.SetInteger("AnimatorState", 1);
        }
        else
        {
            anim.SetInteger("AnimatorState", 0);
        }

    }

}
