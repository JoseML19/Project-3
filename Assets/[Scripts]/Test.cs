using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string name = "Wanis";
    // Start is called before the first frame update
    bool answer1 = true && true;
    //here is a comment
    //here is another comment
    //here is a third comment
    //here is a fourth comment
    //here is a fifth comment
    //here is a sixth comment
    //here is a seventh comment
    //here is a eighth comment
    //here is a ninth comment
    //here is a tenth comment
    void Start()
    {
        Debug.Log(answer1);
        name = "Wanis";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello " + name + "!");
    }
}
