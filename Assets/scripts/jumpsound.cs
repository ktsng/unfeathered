using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpsound : MonoBehaviour
{
    public AudioSource jump;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            jump.Play();
        }
    }
}
