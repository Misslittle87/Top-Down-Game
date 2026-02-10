using UnityEngine;
using Assets._Project.Script.Characters;
using Assets._Project.Script.Combat;



namespace Assets._Project.Script.Player
{
    public class PlayerShooting : MonoBehaviour
    {
        [SerializeField] private GameObject arrowPrefab;
        [SerializeField] private float arrowSpeed = 10f;

        private Vector2 lastLookDirection = Vector2.down;

        private BaseMovement movement;
        private PlayerControls controls;

        private void Awake()
        {
            movement = GetComponent<BaseMovement>();
            controls = new PlayerControls();
        }

        private void OnEnable()
        {
            controls.Enable();
        }

        private void OnDisable()
        {
            controls.Disable();
        }

        private void Update()
        {
            if (movement.MoveDirection.sqrMagnitude > 0.001f)
                lastLookDirection = movement.MoveDirection.normalized;

            if (controls.GamePlay.Shoot.triggered)
            {
                Shoot(lastLookDirection);
            }
        }

        private void Shoot(Vector2 direction)
        {
            GameObject arrow = Instantiate(arrowPrefab, transform.position, Quaternion.identity);

            Projectile projectile = arrow.GetComponent<Projectile>();
            projectile.Launch(direction, arrowSpeed);
        }
    }
}
