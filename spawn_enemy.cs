using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy : MonoBehaviour
{
    public float RaDXNum = 0f;
    public float RaDZNum = 0f;

    

    public GameObject capsulePrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            RaDXNum = Random.Range(-14, 14);
            RaDZNum = Random.Range(-14, 14);

            

        
            Instantiate(capsulePrefab, new Vector3 (RaDXNum, 0, RaDZNum), Quaternion.identity);
            
        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
