using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Assets._Project.Script.UI
{

    public class HealthBar : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private Slider healthbarSlider;
        [SerializeField] private Gradient gradient;
        [SerializeField] private Image fill;

        public void SetMaxHealth(int health)
        {
            healthbarSlider.maxValue = health;
            healthbarSlider.value = health;
            if (fill != null)
                fill.color = gradient.Evaluate(1);
        }

        public void SetHealth(int health)
        {
            Debug.Log($"Slider value set to: {healthbarSlider.value} / {healthbarSlider.maxValue}");

            healthbarSlider.value = health;
            if (fill != null)
                fill.color = gradient.Evaluate(healthbarSlider.normalizedValue);


        }
    }
}
