using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueeeeeButton : MonoBehaviour
{
    public AudioSource buttonSound;

    public void shoesScene() {
        StartCoroutine(ButtonSoundDelayyyyy());
    }

    IEnumerator ButtonSoundDelayyyyy() {
        buttonSound.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Shoes");
    }
}
