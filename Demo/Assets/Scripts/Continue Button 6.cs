using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueeeeeeButton : MonoBehaviour
{
    public AudioSource buttonSound;

    public void reviewScene() {
        StartCoroutine(ButtonSoundDelayyyyyy());
    }

    IEnumerator ButtonSoundDelayyyyyy() {
        buttonSound.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Review");
    }
}
