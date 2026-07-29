using UnityEngine;

public class HairUIDriver : MonoBehaviour {

    public GameObject option1;
    public GameObject option3;

    // void Start() {
    //     if (Attributes.instance.skinTone == "Option 1") {
            
    //     }
    public void changeHair1() {
        Attributes.instance.ChangeHair("Option 1");
        option1.SetActive(true);
        option3.SetActive(false);
    }
    public void changeHair3() {
        Attributes.instance.ChangeHair("Option 3");
        option1.SetActive(false);
        option3.SetActive(true);
    }
}