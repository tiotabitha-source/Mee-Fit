using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopUIDriver : MonoBehaviour
{
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;
    public GameObject skinTone1;
    public GameObject skinTone2;
    public GameObject skinTone3;
    public GameObject skinTone4;
    public GameObject hair1;
    public GameObject hair2;
    public GameObject hair3;
    public GameObject hair4;

    void Start() {
        if (Attributes.instance.skinTone == "Option 1") {
            skinTone1.SetActive(true);
        }
        if (Attributes.instance.skinTone == "Option 2") {
            skinTone2.SetActive(true);
        }
        if (Attributes.instance.skinTone == "Option 3") {
            skinTone3.SetActive(true);
        }
        if (Attributes.instance.skinTone == "Option 4") {
            skinTone4.SetActive(true);
        }
        if (Attributes.instance.hair == "Option 1") {
            hair1.SetActive(true);
        }
        if (Attributes.instance.hair == "Option 2") {
            hair2.SetActive(true);
        }
        if (Attributes.instance.hair == "Option 3") {
            hair3.SetActive(true);
        }
        if (Attributes.instance.hair == "Option 4") {
            hair4.SetActive(true);
        }
    }

    public void changeTop1() {
        Attributes.instance.ChangeTop("Option 1");
        option1.SetActive(true);
        option2.SetActive(false);
        option3.SetActive(false);
        option4.SetActive(false);
    }
    public void changeTop2() {
        Attributes.instance.ChangeTop("Option 2");
        option2.SetActive(true);
        option1.SetActive(false);
        option3.SetActive(false);
        option4.SetActive(false);
    }
    public void changeTop3() {
        Attributes.instance.ChangeTop("Option 3");
        option3.SetActive(true);
        option2.SetActive(false);
        option1.SetActive(false);
        option4.SetActive(false);
    }
    public void changeTop4() {
        Attributes.instance.ChangeTop("Option 4");
        option4.SetActive(true);
        option2.SetActive(false);
        option3.SetActive(false);
        option1.SetActive(false);
    }
}