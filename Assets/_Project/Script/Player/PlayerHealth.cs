using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets._Project.Script.Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int maxHealth = 100;

        public int MaxHealth => maxHealth;
        public int CurrentHealth { get; private set; }

        public event Action<int, int> OnHealthChanged;
        public event Action OnDeath;

        private void Awake()
        {
            CurrentHealth = maxHealth;
        }

        private void Start()
        {
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }

        private void Update()
        {
            if (Keyboard.current == null) return;

            if (Keyboard.current.kKey.wasPressedThisFrame)
                TakeDamage(10);

            if (Keyboard.current.lKey.wasPressedThisFrame)
                Heal(10);
        }

        public void TakeDamage(int damage)
        {
            if (damage <= 0) return;
            if(CurrentHealth <= 0) return;

            CurrentHealth = Mathf.Max(CurrentHealth - damage, 0);

            Debug.Log($"Player took {damage} damage. HP: {CurrentHealth}/{MaxHealth}");

            if (CurrentHealth <= 0)
                OnDeath?.Invoke();

            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }

        public void Heal(int health)
        {
            if (health <= 0) return;
            if(CurrentHealth <= 0) return;

            CurrentHealth = Mathf.Min(CurrentHealth + health, MaxHealth);

            Debug.Log($"Player healed {health}. HP: {CurrentHealth}/{MaxHealth}");


            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }

        public void SetMaxHealth(int health)
        {
            maxHealth = Mathf.Max(1, health);
            CurrentHealth = Mathf.Min(CurrentHealth, maxHealth);

            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }
    }
}
