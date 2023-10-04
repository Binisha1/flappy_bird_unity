using UnityEngine;

public class Tapstart : MonoBehaviour
{
    public GameObject taptostart;
    public BackgroundMove bg;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            taptostart.SetActive(false);
            bg.enabled = true;
        }
    }
}
