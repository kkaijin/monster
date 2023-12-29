using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    
    float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Vertical");
        
        

       

        transform.Translate(Vector3.forward * y * Time.deltaTime * 20);
        
    }

    void OnCollisionEnter(Collision obj)
    {
        if(obj.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
