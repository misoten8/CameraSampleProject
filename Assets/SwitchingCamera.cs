using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingCamera : MonoBehaviour {

    private Cinemachine.CinemachineVirtualCamera vcam;

    public const int PRIORITY_HIGH = 13; // 優先度 高
    public const int PRIORITY_LOW = PRIORITY_HIGH - 2; // HIGHより低ければなんでもOK

    int g_switch = 0;

    void Update()
    {
        if (Input.GetKeyDown("3"))
        {
            g_switch++;
        }

        if (g_switch == 1)
        {
            SetPriority(PRIORITY_HIGH);

        }

        if ( g_switch == 2)
        {
            SetPriority(PRIORITY_LOW);
 
        }
        if (g_switch >= 2)
        {
            g_switch = 0;
        }
    }


    private void SetPriority(int priority)
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
