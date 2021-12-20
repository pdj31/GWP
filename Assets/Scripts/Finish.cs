using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Enviro"){
            CompleteLevel();
        }

        if(other.gameObject.name == "player"){
            CompleteLevel();
        }
    }

    private void CompleteLevel(){
        Debug.Log("going to level 2...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame

}
