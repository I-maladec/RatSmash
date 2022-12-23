using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] Image _filledImage;
    [SerializeField] TextMeshProUGUI _hpText;
    // Start is called before the first frame update
    void Start()
    {
        SetHpAmount(30, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetHpAmount(float currentHealth, float maxHealth)
    {
        _filledImage.fillAmount = currentHealth/maxHealth;
        _hpText.text = $"{currentHealth}/{maxHealth}";
    }
}
