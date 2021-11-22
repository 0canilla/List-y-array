using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private List<GameObject> Cameras;
    [SerializeField] private int indexcamera = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            indexcamera++;
            if (indexcamera == Cameras.Count)
            {
                indexcamera = 0;
            }
            SwitchCamera(indexcamera);
;
        }
    }

    void SwitchCamera(int index)
    {
        foreach (var camera in Cameras)
        {
            camera.SetActive(false);
        }
        Cameras[index].SetActive(true);
    }
}
