using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueeButton : MonoBehaviour
{
    public AudioSource buttonSound;

    public void hairScene() {
        StartCoroutine(ButtonSoundDelayy());
    }

    IEnumerator ButtonSoundDelayy() {
        buttonSound.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Hair");
    }
}
