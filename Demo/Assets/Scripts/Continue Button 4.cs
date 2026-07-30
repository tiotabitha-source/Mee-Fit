using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueeeeButton : MonoBehaviour
{
    public AudioSource buttonSound;

    public void bottomsScene() {
        StartCoroutine(ButtonSoundDelayyyy());
    }

    IEnumerator ButtonSoundDelayyyy() {
        buttonSound.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Bottoms");
    }
}
