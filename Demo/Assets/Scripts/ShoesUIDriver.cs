using UnityEngine;

public class ShoesUIDriver : MonoBehaviour {

    public GameObject option1;

    public void changeShoes1() {
        Attributes.instance.ChangeShoes("Option 1");
        option1.SetActive(true);
    }
}