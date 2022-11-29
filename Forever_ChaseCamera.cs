﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 계속 카메라가 쫓아간다
public class Forever_ChaseCamera : MonoBehaviour
{

    void LateUpdate()
    { 
        Vector3 pos = this.transform.position; // 자신의 위치
        pos.z = -10; // 카메라이므로 앞으로 이동시킨다 
        Camera.main.gameObject.transform.position = pos;
    }
}
