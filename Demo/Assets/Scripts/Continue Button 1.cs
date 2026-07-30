using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public AudioSource buttonSound;

    public void skinScene() {
        StartCoroutine(ButtonSoundDelay());
    }

    IEnumerator ButtonSoundDelay() {
        buttonSound.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Skin Tone");
    }
}
