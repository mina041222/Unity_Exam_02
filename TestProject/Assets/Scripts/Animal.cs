using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal  //MonoBehaviour �پ� ���� �ʱ� ������ ���� commont ���� ���� 
{
    //������ ���� ���� 
    public string name;
    public string sound;

    public void PlaySound()
    {
        Debug.Log(name + ":" + sound);
    }
}
