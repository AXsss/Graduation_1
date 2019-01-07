using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAnimation : MonoBehaviour {

    private Animator anim;

    void Start () {
        anim = GetComponent<Animator>();
    }
	
    public void AnimaMoveRunVertical(int Vertical)
    {
        anim.SetInteger("Vertical", Vertical);
    }
    public void AnimaMoveRunHorizontal(int Horizontal)
    {
        anim.SetInteger("Horizontal", Horizontal);
    }
}
