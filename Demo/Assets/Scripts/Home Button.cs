using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    public AudioSource buttonSound;

    public void returnBack() {
        StartCoroutine(ButtonSoundDelayyyyyyy());
    }

    IEnumerator ButtonSoundDelayyyyyyy() {
        buttonSound.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Skin Tone");
    }
}
