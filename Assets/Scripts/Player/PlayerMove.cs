using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    Rigidbody playerRigidbody;
    int floorMask;//地板层级
    float rayLength;//射线长度
    public float playerSpeed;
    private int[] V_H = new int[2];

// Use this for initialization
void Start () {
        playerRigidbody = GetComponent<Rigidbody>();
        floorMask = LayerMask.GetMask("Floor");
        rayLength = 100f;
        playerSpeed = 5f;
    }
    public int[] Move()
    {
        V_H[1] = (int)Input.GetAxisRaw("Horizontal");
        V_H[0] = (int)Input.GetAxisRaw("Vertical");
        Vector3 vector = new Vector3(V_H[1], 0, V_H[0]);
        vector = transform.position + vector.normalized * playerSpeed * Time.deltaTime;
        playerRigidbody.MovePosition(vector);
        return V_H;
    }

    //人物朝向鼠标
    public void Rotate()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;
        if (Physics.Raycast(mouseRay, out floorHit, rayLength, floorMask))
        {
            //Debug.Log("ll");
            Vector3 playerRotate = floorHit.point - transform.position;//
            playerRotate.y = 0;
            Quaternion rotate = Quaternion.LookRotation(playerRotate);
            gameObject.transform.rotation = rotate;
            //Debug.Log("LL：" + playerRigidbody.transform.rotation);
        }
    }
  
}
