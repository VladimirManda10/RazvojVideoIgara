using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour
{
    [SerializeField] private GameObject content;

    public void EmptyScrollContent()
    {
        foreach(Transform c in content.transform)
        {
            Destroy(c.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
