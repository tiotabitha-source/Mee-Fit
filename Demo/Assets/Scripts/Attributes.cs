using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    public static Attributes instance;
    public string skinTone;
    public string hair;
    public string top;
    public string bottoms;
    public string shoes;

    void Awake() {
        instance = this;
        if (instance !=this) {Destroy(this);}
        DontDestroyOnLoad(this);
    }

    public void ChangeSkin(string option) {skinTone = option;}
    public void ChangeHair(string option) {hair = option;}
    public void ChangeTop(string option) {top = option;}
    public void ChangeBottoms(string option) {bottoms = option;}
    public void ChangeShoes(string option) {shoes = option;}

    

    

    
    
    
}
