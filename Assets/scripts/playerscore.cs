using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerscore : MonoBehaviour
{



    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D trig) {
        if (trig.gameObject.name == "Owl") {
            
            SceneManager.LoadScene(2);
        }
        if (trig.gameObject.name == "Worm") {
            SceneManager.LoadScene(0);
        }

    }
}
