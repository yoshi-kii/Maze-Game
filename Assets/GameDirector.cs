using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject player;
    GameObject goal;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player body");
        this.goal = GameObject.Find("goal");
        this.distance = GameObject.Find("Distance");

    }

    // Update is called once per frame
    void Update()
    {
        float length =   this.player.transform.position.z
            - this.goal.transform.position.z;
        this.distance.GetComponent<Text>().text =
            "ゴールまで" + length.ToString("F2") + "m";



        
    }
}
