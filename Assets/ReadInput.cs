using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ReadInput : MonoBehaviour
{
    private string input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadStringInput(string s)
    {
        input=s;
        Debug.Log(input);
        
    }
    public float  transform(string input)
    {
    
string[] components = input.Split("x"[0]);
if (components.Length == 1) {
return float.Parse(components[0]);
}
return float.Parse(components[0]) * float.Parse(components[1]);
    }
}
