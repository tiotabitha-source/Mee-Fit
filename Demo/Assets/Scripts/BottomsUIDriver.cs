using UnityEngine;

public class BottomsUIDriver : MonoBehaviour {

    public GameObject option1;

    public void changeBottoms1() {
        Attributes.instance.ChangeBottoms("Option 1");
        option1.SetActive(true);
    }
}