using UnityEngine;

public class HairUIDriver : MonoBehaviour {

    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;
    public GameObject skinTone1;
    public GameObject skinTone2;
    public GameObject skinTone3;
    public GameObject skinTone4;

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
    }

    public void changeHair1() {
        Attributes.instance.ChangeHair("Option 1");
        option1.SetActive(true);
        option2.SetActive(false);
        option3.SetActive(false);
        option4.SetActive(false);
    }
    public void changeHair2() {
        Attributes.instance.ChangeHair("Option 2");
        option1.SetActive(false);
        option2.SetActive(true);
        option3.SetActive(false);
        option4.SetActive(false);
    }
    public void changeHair3() {
        Attributes.instance.ChangeHair("Option 3");
        option1.SetActive(false);
        option2.SetActive(false);
        option3.SetActive(true);
        option4.SetActive(false);
    }
    public void changeHair4() {
        Attributes.instance.ChangeHair("Option 4");
        option1.SetActive(false);
        option2.SetActive(false);
        option3.SetActive(false);
        option4.SetActive(true);
    }
}