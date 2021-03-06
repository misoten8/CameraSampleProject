﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2birdeye : MonoBehaviour {

    private Cinemachine.CinemachineVirtualCamera vcam;

    public void SetPriority(int priority)
    {
        if (vcam == null)
        {
            vcam = GetComponent<Cinemachine.CinemachineVirtualCamera>();
        }

        if (vcam)
        {
            vcam.Priority = priority;
        }
    }
}
