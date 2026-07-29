using UnityEngine;

public class BottomsUIDriver : MonoBehaviour {

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
    public GameObject top1;
    public GameObject top2;
    public GameObject top3;
    public GameObject top4;

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
        if (Attributes.instance.top == "Option 1") {
            top1.SetActive(true);
        }
        if (Attributes.instance.top == "Option 2") {
            top2.SetActive(true);
        }
        if (Attributes.instance.top == "Option 3") {
            top3.SetActive(true);
        }
        if (Attributes.instance.top == "Option 4") {
            top4.SetActive(true);
        }
    }

    public void changeBottoms1() {
        Attributes.instance.ChangeBottoms("Option 1");
        option1.SetActive(true);
    }
    public void changeBottoms2() {
        Attributes.instance.ChangeBottoms("Option 2");
        option2.SetActive(true);
    }
    public void changeBottoms3() {
        Attributes.instance.ChangeBottoms("Option 3");
        option3.SetActive(true);
    }
    public void changeBottoms4() {
        Attributes.instance.ChangeBottoms("Option 4");
        option4.SetActive(true);
    }
}