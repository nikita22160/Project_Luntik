using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {

    public GameObject Player;
    public int Distance_;


    public void OnButtonRight()
    {
        Distance_= 2;
        Player.transform.Translate(Distance_, 0, 0);
    }

    public void OnButtonLeft()
    {
        Distance_= -2;
        Player.transform.Translate(Distance_, 0, 0);
    }




    public void OnButtonUp()
    {
        Distance_= 2;

        Player.transform.Translate(0, Distance_, 0);
    }

    public void OnButtonDown()
    {
        Distance_= -2;
        Player.transform.Translate(0, Distance_, 0);
    }
}
