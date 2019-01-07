using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagers : MonoBehaviour {

    public GameObject Player;
    PlayerMove playerMove;
    SoldierAnimation soldierAnimation;
    // Use this for initialization
    void Start () {
        playerMove = Player.GetComponent<PlayerMove>();
        soldierAnimation = Player.GetComponent<SoldierAnimation>();

    }
	
	// Update is called once per frame
	void Update () {
        playerMove.Rotate();
        int [] V_H= playerMove.Move();

        Debug.Log("PlayerManager:"+ V_H[0]+":"+V_H[1]);
        soldierAnimation.AnimaMoveRunVertical(V_H[0]);
        if (V_H[0] == 0)soldierAnimation.AnimaMoveRunHorizontal(V_H[1]);
        
    }
}
