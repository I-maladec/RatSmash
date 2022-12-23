using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeMaster : MonoBehaviour
{
    [SerializeField] Slider slider;
    string prefName = "Volume";
    float volume;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat(prefName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetVolume(float multiplier)
    {
        volume = multiplier;
        PlayerPrefs.SetFloat(prefName, volume);
    }
    public float GetVolume()
    {
        volume = PlayerPrefs.GetFloat(prefName);
        return volume;
    }
}
