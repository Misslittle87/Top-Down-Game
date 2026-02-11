using Assets._Project.Script.Characters;
using Assets._Project.Script.Combat;
using UnityEngine;
using UnityEngine.InputSystem;



namespace Assets._Project.Script.Player
{
    public class PlayerShooting : MonoBehaviour
    {
        [SerializeField] private GameObject arrowPrefab;
        [SerializeField] private float arrowSpeed = 10f;

        private Vector2 lastLookDirection = Vector2.down;
        private Player player;

        private void Awake()
        {
            player = GetComponent<Player>();
        }

        private void OnEnable()
        {
            player.Controls.GamePlay.Shoot.performed += OnShoot;
        }

        private void OnDisable()
        {
            player.Controls.GamePlay.Shoot.performed -= OnShoot;
        }

        private void Update()
        {
            // Uppdatera vilken riktning vi tittar åt (baserat på movement)
            Vector2 move = player.Movement.MoveDirection;

            if (move.sqrMagnitude > 0.001f)
                lastLookDirection = move.normalized;
        }

        private void OnShoot(InputAction.CallbackContext context)
        {
            GameObject arrow = Instantiate(arrowPrefab, transform.position, Quaternion.identity);

            Projectile projectile = arrow.GetComponent<Projectile>();
            projectile.Launch(lastLookDirection, arrowSpeed);
        }
    }
}
