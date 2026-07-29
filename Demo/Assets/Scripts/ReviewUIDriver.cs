using UnityEngine;

public class ReviewUIDriver : MonoBehaviour {

    public GameObject skinTone1;
    public GameObject skinTone2;
    public GameObject skinTone3;
    public GameObject skinTone4;
    public GameObject hair1;
    public GameObject hair3;
    public GameObject top1;
    public GameObject bottoms1;
    public GameObject shoes1;

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
        if (Attributes.instance.hair == "Option 3") {
            hair3.SetActive(true);
        }
        if (Attributes.instance.top == "Option 1") {
            top1.SetActive(true);
        }
        if (Attributes.instance.bottoms == "Option 1") {
            bottoms1.SetActive(true);
        }
        if (Attributes.instance.shoes == "Option 1") {
            shoes1.SetActive(true);
        }
    }
}