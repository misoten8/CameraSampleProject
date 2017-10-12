using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : MonoBehaviour {
    public unitychandemo1   player1;
    public yukoDemo1 player2;
    public player1camera camera1;
    public player2camera camera2;
    public player1birdeye bird1;
    public player2birdeye bird2;
    int g_switch = 1;
    int g_birdswitch = 0;
    public const int PRIORITY_SUPERHIGH = PRIORITY_HIGH + 1; // 優先度 高
    public const int PRIORITY_HIGH      = 15; // 優先度 高
    public const int PRIORITY_LOW       = PRIORITY_HIGH - 1; // HIGHより低ければなんでもOK
    // Use this for initialization
    void Start ()
    {
        player1 = GameObject.Find("unitychan").GetComponent<unitychandemo1>();
        player2 = GameObject.Find("yukochan").GetComponent<yukoDemo1>();
        camera1 = GameObject.Find("CM Player1").GetComponent<player1camera>();
        camera2 = GameObject.Find("CM Player2").GetComponent<player2camera>();
        bird1 = GameObject.Find("CM bird1").GetComponent<player1birdeye>();
        bird2 = GameObject.Find("CM bird2").GetComponent<player2birdeye>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("1"))
        {
            g_switch = 1;
        }
        else if (Input.GetKeyDown("2"))
        {
            g_switch = 2;
        }
        else if (Input.GetKeyDown("3"))
        {
            g_birdswitch ++;
        }

        if (g_switch == 1)
        {
            player1.PlayerActive(true);
            player2.PlayerActive(false);
            camera1.SetPriority(PRIORITY_HIGH);
            camera2.SetPriority(PRIORITY_LOW);
            bird1.SetPriority(PRIORITY_LOW);
            bird2.SetPriority(PRIORITY_LOW);
            //プレイヤー１俯瞰始点
            if (g_birdswitch == 0)
            {
                bird1.SetPriority(PRIORITY_LOW);
            }
            else if (g_birdswitch == 1)
            {
                bird1.SetPriority(PRIORITY_SUPERHIGH);
            }
        }

        else if (g_switch == 2)
        {
            player1.PlayerActive(false);
            player2.PlayerActive(true);
            camera1.SetPriority(PRIORITY_LOW);
            camera2.SetPriority(PRIORITY_HIGH);
            bird1.SetPriority(PRIORITY_LOW);
            bird2.SetPriority(PRIORITY_LOW);
            //プレイヤー2俯瞰始点
            if (g_birdswitch == 0)
            {
                bird2.SetPriority(PRIORITY_LOW);
            }
            else if (g_birdswitch == 1)
            {
                bird2.SetPriority(PRIORITY_SUPERHIGH);
            }
        }
        if (g_birdswitch >= 2)
        {
            g_birdswitch = 0;
        }

    }
}
