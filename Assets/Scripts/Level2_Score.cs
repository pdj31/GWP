using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2_Score : MonoBehaviour
{
    // Start is called before the first frame update
    private static int scorel2 = 0;

    private void OnCollisionEnter(Collision other) {
        Debug.Log("COlliding...");
        if(other.gameObject.name == "bus_l2"){
            scorel2+=1;
            Debug.Log("Score in this level is " + scorel2);
        }
        if(other.gameObject.name == "solar_panel"){
            scorel2+=1;
            Debug.Log("Score in this level is " + scorel2);
        }
        if(other.gameObject.name == "trees_l2"){
            scorel2+=1;
            Debug.Log("Score in this level is " + scorel2);
        }
        if(other.gameObject.name == "low-poly-mill"){
            scorel2+=1;
            Debug.Log("Score in this level is " + scorel2);
        }
        if(other.gameObject.name == "nescafe_mug"){
            scorel2+=1;
            Debug.Log("Score in this level is " + scorel2);
        }
    }
}
