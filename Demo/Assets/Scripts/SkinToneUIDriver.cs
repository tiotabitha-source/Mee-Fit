using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinToneUIDriver : MonoBehaviour
{

    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;

    public void changeSkin1() {
        Attributes.instance.ChangeSkin("Option 1");
        option1.SetActive(true);
        option2.SetActive(false);
        option3.SetActive(false);
        option4.SetActive(false);
    }
    public void changeSkin2() {
        Attributes.instance.ChangeSkin("Option 2");
        option2.SetActive(true);
        option1.SetActive(false);
        option3.SetActive(false);
        option4.SetActive(false);
    }
    public void changeSkin3() {
        Attributes.instance.ChangeSkin("Option 3");
        option3.SetActive(true);
        option2.SetActive(false);
        option1.SetActive(false);
        option4.SetActive(false);
    }
    public void changeSkin4() {
        Attributes.instance.ChangeSkin("Option 4");
        option4.SetActive(true);
        option2.SetActive(false);
        option3.SetActive(false);
        option1.SetActive(false);
    }
}
