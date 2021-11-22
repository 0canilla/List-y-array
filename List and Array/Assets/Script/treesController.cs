using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treesController : MonoBehaviour
{
    [SerializeField] private GameObject[] Trees;
    [SerializeField] private GameObject Selecter;
    // Start is called before the first frame update
    void Start()
    {
        DisableTrees();
        ActiveTree();
    }

    // Update is called once per frame
    void Update()
    {
        int TreeIndex = Random.Range(0, Trees.Length);
        Selected(Trees[TreeIndex].transform);
    }

    private void DisableTrees()
    {
        for (int i = 0; i < Trees.Length; i++)
        {
            Trees[i].GetComponent<TreeController>().IsActive = false;
        }
    }

    private void ActiveTree()
    {
        int TreeIndex = Random.Range(0, Trees.Length);
        Trees[TreeIndex].SetActive(true);
        Trees[TreeIndex].GetComponent<TreeController>().IsActive = true;
        
    }

    private void Selected(Transform target)
    {
        Selecter.transform.position = new Vector3(target.position.x, target.position.y + 2, target.position.z);
    }
}
    