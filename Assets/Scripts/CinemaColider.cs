using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemaColider : MonoBehaviour {

    private Cinemachine.CinemachineVirtualCamera vcam;

    public const int PRIORITY_HIGH = 11; // 優先度 高
    public const int PRIORITY_LOW = PRIORITY_HIGH - 1; // HIGHより低ければなんでもOK


    void OnTriggerEnter(Collider col)
    {
        SetPriority(PRIORITY_HIGH);
    }

    void OnTriggerExit(Collider col)
    {
        SetPriority(PRIORITY_LOW);
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
