using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    [SerializeField] public bool IsActive = false;
    [SerializeField] GameObject[] Fruits;
    [SerializeField] GameObject Spawn;
    private float grow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (IsActive == true)
        {
            Active();
        }
    }

    private void Active()
    {
        grow += Time.deltaTime;
        if (grow >= 5)
        {
            InvokeRepeating("SpawnFruit", 2, 1.5f);
            grow = 0;
        }
        
    }

    private void SpawnFruit()
    {
        Instantiate(Fruits[0], Spawn.transform.position, Quaternion.identity);
    }
}
