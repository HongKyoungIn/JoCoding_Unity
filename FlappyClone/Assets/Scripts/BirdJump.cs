using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour {

    Rigidbody2D rb; // Rigidbody2D 자료형의 rb변수를 선언한다.

    void Start() {
        rb = GetComponent<Rigidbody2D>(); // rb변수 안에 Rigidbody2D 컴포넌트를 받아온다.
    }


    void Update() {
        if(Input.GetMouseButtonDown(0)) { // 마우스 왼쪽 버튼을 눌렀을 때
            rb.velocity = Vector2.up * 4; // velocity = 속도, 위쪽 방향으로 4만큼 속도를 얻는다.
        }
    }
}