using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "��";
        tom.sound = "�Ŀ�!";

        tom.PlaySound();

        Animal Harry = new Animal();
        Harry.name = "�ظ�";
        Harry.sound = "��!��!";

        Harry.PlaySound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
