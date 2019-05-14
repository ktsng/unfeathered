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
            SceneManager.LoadScene(4);
        }
        if (trig.gameObject.name == "Worm-tutorial-win") {
            // go to hard mode
            SceneManager.LoadScene(1);
        }

        if (trig.gameObject.name == "owl-end") {

            SceneManager.LoadScene(2);
        }

        if (trig.gameObject.name == "worm-end") {
            // go to end
            SceneManager.LoadScene(0);
        }
    }
}
