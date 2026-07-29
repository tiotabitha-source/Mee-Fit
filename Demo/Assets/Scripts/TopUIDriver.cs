using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopUIDriver : MonoBehaviour
{
    public GameObject option1;

    public void changeTop1() {
        Attributes.instance.ChangeTop("Option 1");
        option1.SetActive(true);
    }
}