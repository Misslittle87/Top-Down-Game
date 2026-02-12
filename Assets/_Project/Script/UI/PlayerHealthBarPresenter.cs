using Assets._Project.Script.Player;
using UnityEngine;

namespace Assets._Project.Script.UI
{
    public class PlayerHealthBarPresenter : MonoBehaviour
    {
        [SerializeField] private PlayerHealth playerHealth;
        [SerializeField] private HealthBar healthBar;

        private void Awake()
        {
            if (playerHealth == null)
                playerHealth = FindFirstObjectByType<PlayerHealth>();

            if (healthBar == null)
                healthBar = GetComponent<HealthBar>();
        }

        private void OnEnable()
        {
            if (playerHealth != null)
                playerHealth.OnHealthChanged += HandleHealthChanged;
        }

        private void OnDisable()
        {
            if (playerHealth != null)
                playerHealth.OnHealthChanged -= HandleHealthChanged;
        }

        private void Start()
        {
            if (playerHealth == null || healthBar == null) return;

            healthBar.SetMaxHealth(playerHealth.MaxHealth);
            healthBar.SetHealth(playerHealth.CurrentHealth);
        }

        private void HandleHealthChanged(int current, int max)
        {
            if (healthBar == null) return;

            Debug.Log($"UI received health change: {current}/{max}");


            healthBar.SetMaxHealth(max);
            healthBar.SetHealth(current);
        }
    }
}
