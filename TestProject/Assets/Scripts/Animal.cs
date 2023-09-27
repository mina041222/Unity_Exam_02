using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal  //MonoBehaviour 붙어 있지 않기 때문에 따로 commont 붙지 않음 
{
    //동물에 대한 변수 
    public string name;
    public string sound;

    public void PlaySound()
    {
        Debug.Log(name + ":" + sound);
    }
}
