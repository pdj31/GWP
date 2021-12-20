using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Outhit
{
public class Outhit : MonoBehaviour
{
    public static Boolean flag = false;
    public static int score = 0;
    public static String scoreText = "";
    private void OnCollisionEnter(Collision other) 
    {

        flag = true;
        GetComponent<MeshRenderer>().material.color = Color.yellow;
        // if ( flag == true){
        //     score = score + 1;
        //     Debug.Log("Score is "  + score);
        //     flag = false;
        // }
        //  flag = false;
    }
}
}