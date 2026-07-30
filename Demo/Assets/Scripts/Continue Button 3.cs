using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueeeButton : MonoBehaviour
{
    public AudioSource buttonSound;

    public void topScene() {
        StartCoroutine(ButtonSoundDelayyy());
    }

    IEnumerator ButtonSoundDelayyy() {
        buttonSound.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Top");
    }
}
