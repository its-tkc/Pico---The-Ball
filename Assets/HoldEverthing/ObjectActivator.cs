using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivator : MonoBehaviour
{
    Pico pi;
    [SerializeField] static GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateObject()
    {
        if(!obj.activeInHierarchy)
        {
            pi.sj.enabled = true;
            obj.SetActive(true);
            Debug.Log("yes id does");
        }
    }

}
