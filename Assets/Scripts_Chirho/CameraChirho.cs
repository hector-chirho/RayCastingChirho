using UnityEngine;

public class CameraChirho : MonoBehaviour
{
    public GameObject cameraFirstChirho;
    public GameObject cameraSecondChirho;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            ChangeCameraChirho();
        }
    }

    void ChangeCameraChirho()
    {
        if(cameraFirstChirho.activeInHierarchy)
        {
            cameraFirstChirho.SetActive(false);
            cameraSecondChirho.SetActive(true);
        }
        else
        {
            cameraFirstChirho.SetActive(true);
            cameraSecondChirho.SetActive(false);
        }
    }
}
