using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public float speed;
   
    // Update is called once per frame
    void Update()
    {
        Vector3 characterScale = transform.localScale;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition = Vector3.right * speed;
        }
    }
}
