using UnityEngine;

public class ShoesUIDriver : MonoBehaviour {

    public GameObject option1, option2, option3, option4;
    public GameObject skinTone1;
    public GameObject skinTone2;
    public GameObject skinTone3;
    public GameObject skinTone4;
    public GameObject hair1, hair2, hair4;
    public GameObject hair3;
    public GameObject top1, top2, top3, top4;
    public GameObject bottoms1, bottoms2, bottoms3, bottoms4;

    void Start() {
        if (Attributes.instance.skinTone == "Option 1") {
            skinTone1.SetActive(true);
            skinTone2.SetActive(false);
            skinTone3.SetActive(false);
            skinTone4.SetActive(false);
        }
        if (Attributes.instance.skinTone == "Option 2") {
            skinTone2.SetActive(true);
            skinTone1.SetActive(false);
            skinTone3.SetActive(false);
            skinTone4.SetActive(false);
        }
        if (Attributes.instance.skinTone == "Option 3") {
            skinTone3.SetActive(true);
            skinTone2.SetActive(false);
            skinTone1.SetActive(false);
            skinTone4.SetActive(false);
        }
        if (Attributes.instance.skinTone == "Option 4") {
            skinTone4.SetActive(true);
            skinTone2.SetActive(false);
            skinTone3.SetActive(false);
            skinTone1.SetActive(false);
        }
        if (Attributes.instance.hair == "Option 1") {
            hair1.SetActive(true);
            hair2.SetActive(false);
            hair3.SetActive(false);
            hair4.SetActive(false);
        }
        if (Attributes.instance.hair == "Option 2") {
            hair2.SetActive(true);
            hair3.SetActive(false);
            hair1.SetActive(false);
            hair4.SetActive(false);
        }
        if (Attributes.instance.hair == "Option 3") {
            hair3.SetActive(true);
            hair2.SetActive(false);
            hair1.SetActive(false);
            hair4.SetActive(false);
        }
        if (Attributes.instance.hair == "Option 4") {
            hair4.SetActive(true);
            hair3.SetActive(false);
            hair1.SetActive(false);
            hair2.SetActive(false);
        }
        if (Attributes.instance.top == "Option 1") {
            top1.SetActive(true);
            top2.SetActive(false);
            top3.SetActive(false);
            top4.SetActive(false);
        }
        if (Attributes.instance.top == "Option 2") {
            top2.SetActive(true);
            top1.SetActive(false);
            top3.SetActive(false);
            top4.SetActive(false);
        }
        if (Attributes.instance.top == "Option 3") {
            top3.SetActive(true);
            top2.SetActive(false);
            top1.SetActive(false);
            top4.SetActive(false);
        }
        if (Attributes.instance.top == "Option 4") {
            top4.SetActive(true);
            top2.SetActive(false);
            top3.SetActive(false);
            top1.SetActive(false);
        }
        if (Attributes.instance.bottoms == "Option 1") {
            bottoms1.SetActive(true);
            bottoms2.SetActive(false);
            bottoms3.SetActive(false);
            bottoms4.SetActive(false);
        }
        if (Attributes.instance.bottoms == "Option 2") {
            bottoms2.SetActive(true);
            bottoms1.SetActive(false);
            bottoms3.SetActive(false);
            bottoms4.SetActive(false);
        }
        if (Attributes.instance.bottoms == "Option 3") {
            bottoms1.SetActive(false);
            bottoms2.SetActive(false);
            bottoms3.SetActive(true);
            bottoms4.SetActive(false);
        }
        if (Attributes.instance.bottoms == "Option 4") {
            bottoms1.SetActive(false);
            bottoms2.SetActive(false);
            bottoms3.SetActive(false);
            bottoms4.SetActive(true);
        }
    }

    public void changeShoes1() {
        Attributes.instance.ChangeShoes("Option 1");
        option1.SetActive(true);
        option2.SetActive(false);
        option3.SetActive(false);
        option4.SetActive(false);
    }
    public void changeShoes2() {
        Attributes.instance.ChangeShoes("Option 2");
        option2.SetActive(true);
        option1.SetActive(false);
        option3.SetActive(false);
        option4.SetActive(false);
    }
    public void changeShoes3() {
        Attributes.instance.ChangeShoes("Option 3");
        option3.SetActive(true);
        option2.SetActive(false);
        option1.SetActive(false);
        option4.SetActive(false);
    }
    public void changeShoes4() {
        Attributes.instance.ChangeShoes("Option 4");
        option4.SetActive(true);
        option2.SetActive(false);
        option3.SetActive(false);
        option1.SetActive(false);
    }
}